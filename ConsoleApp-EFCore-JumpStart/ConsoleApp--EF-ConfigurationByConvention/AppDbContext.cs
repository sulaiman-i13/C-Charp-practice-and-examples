using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Tweet> Tweets { get; set; }
    public DbSet<Comment> Comments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;
        optionsBuilder.UseSqlServer(connectionString);

    }
}
