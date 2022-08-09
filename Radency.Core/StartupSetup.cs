using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Radency.Contracts.Services;
using Radency.Core.Mapper;
using Radency.Core.Services;
using Radency.Core.Validators;

namespace Radency.Core
{
    public static class StartupSetup
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ApplicationProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddFluentValidator(this IServiceCollection services)
        {
            services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<AddRaitingValidator>());
        }
    }
}
