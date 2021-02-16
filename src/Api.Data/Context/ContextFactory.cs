using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            var connectionString = "";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();

            optionsBuilder.UseSqlServer (connectionString);
            return new MyContext (optionsBuilder.Options);
        }
    }
}