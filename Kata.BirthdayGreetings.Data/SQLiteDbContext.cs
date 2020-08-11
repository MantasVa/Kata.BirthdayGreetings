using Kata.BirthdayGreetings.Data.Infrastructure;
using Kata.BirthdayGreetings.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Kata.BirthdayGreetings.Data
{
    public class SQLiteDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=C:\\Users\\Mantas\\source\\repos\\Kata.BirthdayGreetings\\Kata.BirthdayGreetings.Data\\BDayDatabase.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedPersonTable();
            base.OnModelCreating(modelBuilder);
        }
    }
}
