using Microsoft.EntityFrameworkCore;
using SignalIR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Contexts;

public class SignalRContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-JMANIK7;initial catalog=SignalRDb;integrated security=true;TrustServerCertificate=true");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimoinal> Testimoinals { get; set; }
}
