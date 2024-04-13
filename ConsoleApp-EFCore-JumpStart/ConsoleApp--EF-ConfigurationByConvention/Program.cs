

using Microsoft.EntityFrameworkCore;


using (var _context = new AppDbContext())
{
    foreach (var user in _context.Users)
    {
        Console.WriteLine(user);
    }
    Console.WriteLine("=========");
        foreach (var t in _context.Tweets)
    {
        Console.WriteLine(t);
    }
    Console.WriteLine("=========");

    foreach (var c in _context.Comments)
    {
        Console.WriteLine(c);
    }
}



