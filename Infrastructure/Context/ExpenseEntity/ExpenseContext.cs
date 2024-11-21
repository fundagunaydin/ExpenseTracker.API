using ExpenseTracker.API.Domain;
using ExpenseTracker.API.Infrastructure.Context.ExpenseEntity.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.API.Infrastructure.Context.ExpenseEntity
{
    public class ExpenseContext : DbContext
    {
        private readonly DbContextOptions _dbContextOptions;
        public ExpenseContext(DbContextOptions options) 
        {
            _dbContextOptions = options;
        }
        public DbSet<Expense> Expense { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExpenseEntityConfiguration(_dbContextOptions));

            base.OnModelCreating(modelBuilder);
        }

    }
}
