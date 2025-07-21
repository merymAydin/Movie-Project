using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Core.Business.Utilities.Security.Jwt;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProject.DataAccess.Repositories.Concrete;
using Ymypprojects.Business.Abstract;
using Ymypprojects.Business.Concrete;

namespace Ymypprojects.Business.DependencyInjection.AutoFac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<MovieManager>().As<IMovieService>();
        builder.RegisterType<EfMovieRepository>().As<IMovieRepository>();
        builder.RegisterType<DirectorManager>().As<IDirectorService>();
        builder.RegisterType<EfDirectorRepository>().As<IDirectorRepository>();
        builder.RegisterType<ActorManager>().As<IActorService>();
        builder.RegisterType<EfActorRepository>().As<IActorRepository>();
        builder.RegisterType<CategoryManager>().As<ICategoryService>();
        builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>();
        builder.RegisterType<UserManager>().As<IUserService>();
        builder.RegisterType<EfUserRepository>().As<IUserRepository>();
        builder.RegisterType<AuthManager>().As<IAuthService>();
        builder.RegisterType<JwtHelper>().As<ITokenHelper>();   
    }
}