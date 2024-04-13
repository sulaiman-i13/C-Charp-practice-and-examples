
using ConsoleApp.EF.QueryData1.Data;
using ConsoleApp.EF.QueryData1.Entities;
using Microsoft.EntityFrameworkCore;

#region improper projection
//using (var context=new AppDbContext())
//{
//    var courses = context.Courses.Include(x => x.Sections).Include(c => c.Reviews).ToList();
//    /*
//       SELECT [c].[Id], [c].[CourseName], [c].[HoursToComplete], [c].[Price], [s].[Id], [s].[CourseId], [s].[InstructorId], [s].[ScheduleId], [s].[SectionName], [s].[EndDate], [s].[StartDate], [s].[EndTime], [s].[StartTime], [r].[Id], [r].[CourseId], [r].[CreatedAt], [r].[Feedback]
//  FROM [Courses] AS [c]
//  LEFT JOIN [Sections] AS [s] ON [c].[Id] = [s].[CourseId]
//  LEFT JOIN [Reviews] AS [r] ON [c].[Id] = [r].[CourseId]
//  ORDER BY [c].[Id], [s].[Id]
//     */

//}
#endregion

#region proper projection
//using (var context = new AppDbContext())
//{
//    var courses = context.Courses.AsNoTracking().Select(
//        x=>
//        new {
//            x.Id,
//            x.CourseName,
//            Sections = x.Sections.Select(s => new
//            {
//                s.SectionName,
//                s.Id,
//               Date= s.DateRange.ToString(),
//                Time=s.TimeSlot.ToString(),
//            }),
//            Reviews = x.Reviews.Select(r => new
//            {
//                r.Feedback
//            })
//        }
//        ).ToList();

//    /*
//       SELECT [c].[Id], [c].[CourseName], [s].[SectionName], [s].[Id],
//                [s].[EndDate], [s].[StartDate], [s].[EndTime],
//                [s].[StartTime], [r].[Feedback], [r].[Id]
//      FROM [Courses] AS [c]
//      LEFT JOIN [Sections] AS [s] ON [c].[Id] = [s].[CourseId]
//      LEFT JOIN [Reviews] AS [r] ON [c].[Id] = [r].[CourseId]
//      ORDER BY [c].[Id], [s].[Id]
//     */
//}
#endregion

#region splitting query
//using (var context = new AppDbContext())
//{
//    var courses = context.Courses
//        .Include(x=>x.Sections)
//        .Include(x=>x.Reviews)
//        .AsSplitQuery()
//        .ToList();

//    /*
//      SELECT [c].[Id], [c].[CourseName], [c].[HoursToComplete], [c].[Price]
//      FROM [Courses] AS [c]
//      ORDER BY [c].[Id]

//     SELECT [s].[Id], [s].[CourseId], [s].[InstructorId], [s].[ScheduleId], [s].[SectionName], [s].[EndDate], [s].[StartDate], [s].[EndTime], [s].[StartTime], [c].[Id]
//      FROM [Courses] AS [c]
//      INNER JOIN [Sections] AS [s] ON [c].[Id] = [s].[CourseId]
//      ORDER BY [c].[Id]

//     SELECT [r].[Id], [r].[CourseId], [r].[CreatedAt], [r].[Feedback], [c].[Id]
//      FROM [Courses] AS [c]
//      INNER JOIN [Reviews] AS [r] ON [c].[Id] = [r].[CourseId]
//      ORDER BY [c].[Id]
//     */
//}
#endregion

#region inner  join
//using (var context = new AppDbContext())
//{
//    //qury syntax
//    var result = (from c in context.Courses
//                  join s in context.Sections
//                  on c.Id equals s.CourseId
//                  select new
//                  {
//                      CourseName = c.CourseName,
//                      DateRange = s.DateRange.ToString(),
//                      TimeSlot = s.TimeSlot.ToString()
//                  }).ToList();
//    //method syntax
//    var result2 = context.Courses
//        .Join(context.Sections,
//                    c => c.Id,
//                    s => s.CourseId,
//                    (c, s) => new
//                    {
//                        CourseName = c.CourseName,
//                        DateRange = s.DateRange.ToString(),
//                        TimeSlot = s.TimeSlot.ToString()
//                    }).ToList();
//}
#endregion
#region left outer  join --group join
//using (var context = new AppDbContext())
//{
////qury syntax
//var result =( from o in context.Offices
//             join i in context.Instructors
//             on o.Id equals i.OfficeId
//             into officeVacancy
//             from ov in officeVacancy.DefaultIfEmpty()
//             select new
//             {
//                 OfficeId = o.Id,
//                 o.OfficeName,
//                 InstructorName =ov!=null? ov.FName + " " + ov.LName:"<<Empty>>"
//             }).ToList();
////method syntax
//    var result2 = context.Offices.GroupJoin(context.Instructors,
//                                            o => o.Id,
//                                            i => i.OfficeId,
//                                            (office, instructor) => new
//                                            {
//                                                Office = office,
//                                                Instructor = instructor
//                                            }).SelectMany(ov => ov.Instructor.DefaultIfEmpty(),
//                                            (o, i) =>
//                                            new
//                                            {
//                                                OfficeId = o.Office.Id,
//                                                o.Office.OfficeName,
//                                                InstructorName = i != null? i.FName + " " + i.LName:"<<Empty>>"
//                                            }).ToList();

//    foreach (var ov in result2)
//    {
//        Console.WriteLine($"{ov.OfficeId} - {ov.OfficeName} - {ov.InstructorName}");
//    }

//}

#endregion
#region cross join
//using (var context = new AppDbContext())
//{
//    //query syntax
//    var result = (from s in context.Sections
//                  from i in context.Instructors
//                  select new
//                  {
//                      Section = s.SectionName,
//                      InstructorName = i.FName + " " + i.LName
//                  }).ToList();
//    //method syntax
//    var result2 = context.Sections.SelectMany(s=>context.Instructors,

//                                            (s, i) => new
//                                            {
//                                                Section = s.SectionName,
//                                                InstructorName = i.FName + " " + i.LName
//                                            }).ToList();

//    foreach (var s in result)
//    {
//        Console.WriteLine($"{s.Section} - {s.InstructorName}");
//    }

//}

#endregion
#region SelectMany
//using (var context = new AppDbContext()) {
//    //querysyntax
//    var result = from c in context.Courses
//                 where c.CourseName.Contains("frontend")
//                 from s in c.Sections
//                 from st in s.Participants
//                 select st.FName + " " + st.LName;




//    var result2 = context.Courses.
//        Where(x => x.CourseName.Contains("frontend"))
//        .SelectMany(x => x.Sections)
//        .SelectMany(x => x.Participants)
//        .Select(p => p.FName + " " + p.LName);

//    foreach (var st in result2) Console.WriteLine(st);

//}
#endregion
#region group by
//using (var context = new AppDbContext())
//{
//    var result = from s in context.Sections
//                 group s by s.Instructor
//               into g
//                 select new
//                 {
//                     g.Key,
//                     Sections = g.ToList(),
//                 };
//    var result2 = context.Sections.
//        GroupBy(x => x.Instructor)
//        .Select(x => new
//        {
//            x.Key,
//            Sections = x.ToList()
//        });
//    foreach (var item in result2)
//    {
//        Console.WriteLine(item.Key.FName);
//        foreach (var i in item.Sections) Console.WriteLine(i.SectionName);
//    }


//}

#endregion

#region group by with aggregate
//using (var context = new AppDbContext())
//{
//    var result = from s in context.Sections
//                 group s by s.Instructor
//               into g
//                 select new
//                 {
//                     g.Key,
//                     TotalSections = g.Count(),
//                 };
//    var result2 = context.Sections.
//        GroupBy(x => x.Instructor)
//        .Select(x => new
//        {
//            x.Key,
//            TotalSections = x.Count(),
//        });
//    foreach (var item in result2)
//    {
//        Console.WriteLine($"{item.Key.FName} - [{item.TotalSections}]");
//    }


//}

#endregion

#region pagination

using (var context = new AppDbContext())
{
    var pageSize = 10;
    var totalSections = context.Sections.Count();
    var totalPages = (int)Math.Ceiling((double)totalSections / pageSize);
    var pageNumber = 1;

    var query = context.Sections
        .Include(x => x.Course)
        .Include(x => x.Instructor)
        .Include(x => x.Schedule)
        .Select(x => new
        {
            Course = x.Course.CourseName,
            Instructor = x.Instructor.FName,
            DateRange = x.DateRange.ToString(),
            TimeSlot = x.TimeSlot.ToString(),
            Days = string.Join(" ",
                                x.Schedule.SUN ? "Sun" : "   ",
                                x.Schedule.MON ? "MON" : "   ",
                                x.Schedule.TUE ? "TUE" : "   ",
                                x.Schedule.WED ? "WED" : "   ",
                                x.Schedule.THU ? "THU" : "   ",
                                x.Schedule.FRI ? "FRI" : "   ",
                                x.Schedule.SAT ? "SAT" : "   "
            )
        });
    Console.WriteLine("|           Course                   |          Instructor            |       Date Range        |   Time Slot   |            Days                |");
    Console.WriteLine("|------------------------------------|--------------------------------|-------------------------|---------------|--------------------------------|");
    while (pageNumber <= totalPages) {
        // actual paging
        var pageResult = query.Skip((pageNumber - 1)*pageSize).Take(pageSize);

        foreach (var section in pageResult)
        {
            Console.WriteLine($"| {section.Course,-34} | {section.Instructor,-30} | {section.DateRange.ToString(),-23} | {section.TimeSlot.ToString(),-12} | {section.Days,-30} |");
        }

        Console.WriteLine();

        for (int p = 1; p <= totalPages; p++)
        {
            Console.ForegroundColor = p == pageNumber ? ConsoleColor.Yellow : ConsoleColor.DarkGray;
            Console.Write($"{p} "); // 1 2 3 4 5 .... 20
        }
        Console.ForegroundColor = ConsoleColor.White;
        ++pageNumber;

        Console.ReadKey();
        Console.Clear();
    }
   

}
#endregion


