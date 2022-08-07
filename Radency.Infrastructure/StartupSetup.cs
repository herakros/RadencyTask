using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Radency.Contracts.Data;
using Radency.Infrastructure.Data;
using Radency.Infrastructure.Data.Repositories;

namespace Radency.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }

        public static void AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<RadencyDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
