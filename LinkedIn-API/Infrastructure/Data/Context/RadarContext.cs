using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class RadarContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public RadarContext(DbContextOptions<RadarContext> options) : base(options) { }
    }
}
