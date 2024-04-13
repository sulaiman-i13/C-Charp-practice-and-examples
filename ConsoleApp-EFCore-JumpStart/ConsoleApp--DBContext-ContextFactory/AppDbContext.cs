using Microsoft.EntityFrameworkCore;


public class AppDbContext:DbContext
{
    public DbSet<Wallet> Wallets { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
}
