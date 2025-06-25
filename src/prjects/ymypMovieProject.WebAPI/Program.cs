using ymypMovieProject.DataAccess.Context;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProject.DataAccess.Repositories.Concrete;
using Ymypprojects.Business.Abstract;
using Ymypprojects.Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MovieDbContext>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryRepository,EfCategoryRepository>();
builder.Services.AddScoped<IMovieService,MovieManager>();
builder.Services.AddScoped<IMovieRepository,EfMovieRepository>();
builder.Services.AddScoped<IDirectorService, DirectorManager>();
builder.Services.AddScoped<IDirectorRepository, EfDirectorRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
