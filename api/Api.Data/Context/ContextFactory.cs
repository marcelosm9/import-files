using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //MySQL
            //var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=admin";
            //var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            //.UseMySql(connectionString);

            //SQLServer
            var connectionString = "Server=(LocalDb)\\MSSQLLocalDB; Integrated Security=true; Initial Catalog=import-files-db;";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new MyContext(optionBuilder.Options);
        }
    }
}
