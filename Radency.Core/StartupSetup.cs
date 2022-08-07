using Microsoft.Extensions.DependencyInjection;
using Radency.Contracts.Services;
using Radency.Core.Services;

namespace Radency.Core
{
    public static class StartupSetup
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
        }
    }
}
