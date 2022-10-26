using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Infra.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<SafraContext>
    {
        public SafraContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SafraConsignado;User ID=rfcunha;Password=1234567";
            var optionsBuilder = new DbContextOptionsBuilder<SafraContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new SafraContext(optionsBuilder.Options);
        }
    }
}
