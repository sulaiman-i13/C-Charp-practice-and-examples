
using ConsoleApp.EntityTypesAndMapping;
using ConsoleApp.EntityTypesAndMapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class AppDbContext : DbContext
{
    public DbSet<OrderWithDetailsView> Oreders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrederDetails { get; set; }
    public DbSet<OrderWithDetailsView> OrderWithDetailsViews { get; set; }
    public DbSet<OrderBill> OrderGivenBill { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;
        optionsBuilder.UseSqlServer(connectionString);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Order>().ToTable("Orders", "Sales").HasKey(k => k.Id);
        modelBuilder.Entity<Product>().ToTable("Products", "Inventory").HasKey(k => k.Id);
        modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails", "Sales").HasKey(k => k.Id);
        //modelBuilder.HasDefaultSchema("Sales");
        //modelBuilder.Ignore<SnapShot>();
        //modelBuilder.Entity<AuditEntry>().HasKey(x => x.Id);
        modelBuilder.Entity<OrderWithDetailsView>().ToView("OrderWithDetailsView").HasNoKey();
        modelBuilder.Entity<OrderBill>().HasNoKey().ToFunction("GetOrderBill");
    }
}