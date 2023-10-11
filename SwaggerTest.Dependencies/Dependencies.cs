using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SwaggerTest.BusinessLogic.Interfaces;
using SwaggerTest.BusinessLogic.Services;
using SwaggerTest.DAL.Interfaces;
using SwaggerTest.DAL.Repositories;
using SwaggerTest.Mapper;

namespace SwaggerTest.Dependencies
{
    public static class Dependencies
    {
        public static void AddIService(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUserService, UserService>();
        }

        public static void AddIRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
        }

        public static void AddIMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            var mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}