using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ETicaretData;

public class DataBaseContext : DbContext
{
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Slider> Sliders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\MSSQLLocalDB;
            Database=ETicaretDb;
            Trusted_Connection=True;
            TrustServerCertificate = True"
            ); 

        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new AppUserConfiguration()); // Gerek kalmadı
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
