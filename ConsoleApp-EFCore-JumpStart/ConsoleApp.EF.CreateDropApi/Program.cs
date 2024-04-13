
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
	await context.Database.EnsureCreatedAsync();
	var sql = context.Database.GenerateCreateScript();
	Console.WriteLine(sql);
    await Task.Delay(30000);
	await context.Database.EnsureDeletedAsync();
}