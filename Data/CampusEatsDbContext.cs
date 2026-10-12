
using Microsoft.EntityFrameworkCore;

namespace CampusEats.Api.Data;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
    public bool Available { get; set; }
}

public class CampusEatsDbContext : DbContext
{
    public CampusEatsDbContext(
        DbContextOptions<CampusEatsDbContext> options)
        : base(options)
    {
    }

    public DbSet<MenuItem> MenuItems => Set<MenuItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem { Id = 1, Name = "Kottu Roti", Price = 750m, Category = "Mains", Available = true },
            new MenuItem { Id = 2, Name = "Fried Rice", Price = 850m, Category = "Mains", Available = true },
            new MenuItem { Id = 3, Name = "Veg Sub", Price = 600m, Category = "Snacks", Available = false },
            new MenuItem { Id = 4, Name = "Watalappan", Price = 350m, Category = "Dessert", Available = true },
            new MenuItem { Id = 5, Name = "Iced Milo", Price = 300m, Category = "Drinks", Available = true }
        );
    }
}
