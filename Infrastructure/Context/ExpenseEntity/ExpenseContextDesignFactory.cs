using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace ExpenseTracker.API.Infrastructure.Context.ExpenseEntity
{
    public class ExpenseContextDesignFactory : IDesignTimeDbContextFactory<ExpenseContext>
    {
        public ExpenseContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=172.18.228.86\\KD_SQLDB;Database=Roketsan_MES_Process;User ID=dev_kocdigital_product;Password=9BFJBj=3Y?8\"J&Nq=;";

            //PostgreSQL
            //MSSQL
            var target = "MSSQL";
            var migrationsAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name + "." + target;


            if (target == "PostgreSQL")
            {
                // if used to do
                return null;
            }
            else
            {
                var optionsBuilder = new DbContextOptionsBuilder<ExpenseContext>().UseSqlServer(connectionString,
                    x => x.MigrationsAssembly(migrationsAssembly));
                return new ExpenseContext(optionsBuilder.Options);
            }
        }
    }
}
