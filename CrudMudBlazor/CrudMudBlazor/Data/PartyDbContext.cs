using CrudMudBlazor.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;

namespace CrudMudBlazor.Data
{
    public class PartyDbContext : DbContext
    {
        public DbSet<Party> Parties { get; set; }
        public DbSet<PartyType> PartyTypes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=MyNewPartyDB;Username=postgres;Password =");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>().ToTable("Parties");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Organization>().ToTable("Organization");
        }
    }
}
