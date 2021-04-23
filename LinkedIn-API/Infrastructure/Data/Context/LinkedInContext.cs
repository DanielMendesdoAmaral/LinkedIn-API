using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class LinkedInContext : DbContext
    {
        public DbSet<Vaga> Vagas { get; set; }

        public LinkedInContext(DbContextOptions<LinkedInContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaga>().Property(v => v.Salario).HasColumnType("decimal");
        }
    }
}
