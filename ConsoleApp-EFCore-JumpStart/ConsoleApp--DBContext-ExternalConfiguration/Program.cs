#region read list

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;
var builder = new DbContextOptionsBuilder();
builder.UseSqlServer(connectionString);
var options=builder.Options;
using (var _context = new AppDbContext(options))
{
    foreach (var wallet in _context.Wallets)
    {
        Console.WriteLine(wallet);
    }
}
#endregion


