using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
    public class SalonContext : DbContext
    {
        public DbSet<Stylist> Stylists { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public SalonContext(DbContextOptions options) : base(options) {}
    }
}