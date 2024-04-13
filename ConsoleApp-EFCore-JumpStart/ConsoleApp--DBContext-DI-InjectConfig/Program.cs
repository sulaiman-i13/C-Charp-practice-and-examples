

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

#region get dbContext using Dependency Injection using ServiceCollection
//var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
//var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;
//ServiceCollection? services = new ServiceCollection();//collection of service descriptors
//services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connectionString));
//var provider = services.BuildServiceProvider(); //Creates a ServiceProvider containing services from the provided IServiceCollection
//using (var _context = provider.GetRequiredService<AppDbContext>())
//{
//    foreach (var wallet in _context.Wallets)
//    {
//        Console.WriteLine(wallet);
//    }
//}

#endregion
#region using context concurrently
//AppDbContext _context;
//var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
//var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;
//ServiceCollection? services = new ServiceCollection();//collection of service descriptors
//services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connectionString));
//var provider = services.BuildServiceProvider(); //Creates a ServiceProvider containing services from the provided IServiceCollection
//_context = provider.GetRequiredService<AppDbContext>();

//var tasks = new[]
//{
//    Task.Factory.StartNew(()=>Job1()),
//    Task.Factory.StartNew(()=>Job2()),
//};
//Task.WhenAll(tasks).ContinueWith(t => { Console.WriteLine("jobs done"); });
//async Task Job1()
//{
//   await _context.Wallets.AddAsync(new Wallet { Holder = "Mona", Balance = 10000m });
//    await _context.SaveChangesAsync();
//}
//async Task Job2()
//{
//    await _context.Wallets.AddAsync(new Wallet { Holder = "Ward", Balance = 10000m });
//    await _context.SaveChangesAsync();
//}
//Console.ReadKey();

#endregion

#region DbContextPool
var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;

ServiceCollection services = new ServiceCollection();
services.AddDbContextPool<AppDbContext>(o=>o.UseSqlServer(connectionString));
ServiceProvider serviceProvider = services.BuildServiceProvider();
using(var context = serviceProvider.GetRequiredService<AppDbContext>())
{
	foreach (var item in context.Wallets)
	{
        Console.WriteLine(item);
    }
}

#endregion