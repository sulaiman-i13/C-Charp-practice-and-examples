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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Comment>().ToTable("tblComments");
        //modelBuilder.Entity<Tweet>().ToTable("tblTweets");
        //modelBuilder.Entity<User>().ToTable("tblUsers");
        //modelBuilder.Entity<User>().Property(p=>p.Id).HasColumnName("userId");

        //new UserConfiguration().Configure(modelBuilder.Entity<User>());
        //new TweetConfiguration().Configure(modelBuilder.Entity<Tweet>());
        //new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(User).Assembly);


    }
}
