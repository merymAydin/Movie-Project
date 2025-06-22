using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ymypMovieProjectEntity.Entities;

namespace ymypMovieProject.DataAccess.Context
{
    public sealed class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-HLA9L30F\SQLEXPRESS;Initial Catalog=YmypMovieDb;Integrated Security=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(p => p.IMDB).HasPrecision(4, 2);
            modelBuilder.Entity<Movie>().Property(p=>p.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Movie>().HasKey(p => p.Id);
            modelBuilder.Entity<Movie>().HasOne(p => p.Category).WithMany(c => c.Movies).HasForeignKey(p=>p.CategoryId);

            modelBuilder.Entity<Category>().Property(c=>c.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Category>().Property(c => c.Description).HasMaxLength(250).IsRequired();
            base.OnModelCreating(modelBuilder);


            //Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Aksiyon" },
                new Category { Id = Guid.NewGuid(), Name = "Komedi" },
                new Category { Id = Guid.NewGuid(), Name = "bilim kurgu" },
                new Category { Id = Guid.NewGuid(), Name = "fantastik" },
                new Category { Id = Guid.NewGuid(), Name = "belgesel" },
                new Category { Id = Guid.NewGuid(), Name = "korku" }
                );

        }


        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
