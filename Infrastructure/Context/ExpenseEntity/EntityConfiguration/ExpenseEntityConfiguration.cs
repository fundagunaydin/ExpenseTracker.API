using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ExpenseTracker.API.Domain;

namespace ExpenseTracker.API.Infrastructure.Context.ExpenseEntity.EntityConfiguration
{
    public class ExpenseEntityConfiguration : IEntityTypeConfiguration<Expense>
    {
        private readonly DbContextOptions _options;

        public ExpenseEntityConfiguration(DbContextOptions options)
        {
            _options = options;
        }

        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasIndex(p => new { p.Id }).IsUnique(true);
            builder.Property(p => p.Amount).IsRequired();
        }
    }
}
