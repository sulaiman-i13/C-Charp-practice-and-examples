using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    foreach (var item in context.Sections.Include(x => x.Course))
    {
        Console.WriteLine($"Section: {item.SectionName}, " +
            $"Course {item.Course.CourseName}");
    }
}