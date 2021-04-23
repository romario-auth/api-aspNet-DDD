using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            var connectionString = "Server=localhost,1443;database=dbAPI; User ID=SA; Password=";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();

            optionsBuilder.UseSqlServer (connectionString);
            return new MyContext (optionsBuilder.Options);
        }
    }
}