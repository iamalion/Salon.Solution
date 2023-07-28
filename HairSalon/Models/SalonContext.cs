using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}