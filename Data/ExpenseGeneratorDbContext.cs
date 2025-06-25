using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ExpenseGeneratorDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ExpenseGenerator.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>(entity =>
            {
                entity.OwnsOne(e => e.Metadata);
            });
        }


        public DbSet<Expense> Expense { get; set; }
    }
}
