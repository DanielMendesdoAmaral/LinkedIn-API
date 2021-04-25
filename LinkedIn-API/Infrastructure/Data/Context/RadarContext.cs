using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class RadarContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public RadarContext(DbContextOptions<RadarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().Property(u => u.Latitude).HasColumnType("DECIMAL");
            modelBuilder.Entity<Usuario>().Property(u => u.Longitude).HasColumnType("DECIMAL");
        }
    }
}
