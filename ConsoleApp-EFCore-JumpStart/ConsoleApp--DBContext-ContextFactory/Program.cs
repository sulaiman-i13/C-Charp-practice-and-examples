

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
#region get dbContext using ContextFactory 
var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;


ServiceCollection service = new ServiceCollection();
service.AddDbContextFactory<AppDbContext>(o => o.UseSqlServer(connectionString)
.LogTo(Console.WriteLine,LogLevel.Information));
var provider = service.BuildServiceProvider();
var contextFactory = provider.GetService<IDbContextFactory<AppDbContext>>();


using (var _context = contextFactory!.CreateDbContext())
{
    foreach (var wallet in _context.Wallets)
    {
        Console.WriteLine(wallet);
    }
}

#endregion


