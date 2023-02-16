using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database.InMemory.Context
{
    public class InMemoryContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }

        public InMemoryContext(DbContextOptions<InMemoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasKey(x => x.Id);
            modelBuilder.Entity<Club>().Property(x => x.Name).HasMaxLength(100);

            base.OnModelCreating(modelBuilder);
        }

    }
}
