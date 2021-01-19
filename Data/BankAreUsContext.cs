using BankAreUSEFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAreUSEFCore.Data
{
    class BankAreUsContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Datalagring_BankAreUsEfCore;Trusted_Connection=True");
        }
    }
}
