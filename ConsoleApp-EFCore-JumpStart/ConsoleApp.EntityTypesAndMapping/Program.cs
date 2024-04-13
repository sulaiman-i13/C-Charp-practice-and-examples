

using ConsoleApp.EntityTypesAndMapping;
using Microsoft.EntityFrameworkCore;



using (var _context = new AppDbContext())
{


    //foreach (var item in _context.OrderWithDetailsViews)
    //{
    //    Console.WriteLine(item);
    //}

    var bills = _context.Set<OrderBill>().FromSqlInterpolated($"select * from GetOrderBill(1)").ToList();

foreach (var item in bills)
{
    Console.WriteLine(item);
}

}

