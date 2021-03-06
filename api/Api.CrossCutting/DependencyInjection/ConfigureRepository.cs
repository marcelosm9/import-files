using Api.Data.Context;
using Api.Data.Implementation;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            // serviceCollection.AddDbContext<MyContext>(
            //     options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=admin")
            // );

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB; Integrated Security=true; Initial Catalog=import-files-db;")
            );
        }
    }
}
