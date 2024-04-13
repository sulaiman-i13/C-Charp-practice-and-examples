using ConsoleApp.EF.QueryData1.Data;
using Microsoft.EntityFrameworkCore;
#region get courses
//using (var context=new AppDbContext())
//{
//    var courses = context.Courses;
//    Console.WriteLine(" ======= sql =======");
//    Console.WriteLine(  courses.ToQueryString());
//    Console.WriteLine( " ======= result =======");
//    foreach (var course in courses)
//    {
//        Console.WriteLine($"course name: {course.CourseName}, {course.HoursToComplete},{course.Price:c0} ");
//    }

//}
#endregion
#region get one course
//using (var context = new AppDbContext())
//{
//    var course = context.Courses.Single(c => c.Id == 1);

//    Console.WriteLine(" ======= result =======");
//    Console.WriteLine($"course name: {course.CourseName}, {course.HoursToComplete},{course.Price:c0} ");


//}
#endregion
#region get one course with many values
//using (var context = new AppDbContext())
//{
//    //var course = context.Courses.First(c => c.HoursToComplete==25);
//    var course = context.Courses.FirstOrDefault(c => c.HoursToComplete==255);

//    Console.WriteLine(" ======= result =======");
//    Console.WriteLine($"course name: {course?.CourseName},{course?.Price.ToString()} ");


//}
#endregion

#region get courses with filteration
//using (var context = new AppDbContext())
//{
//    //var course = context.Courses.First(c => c.HoursToComplete==25);
//    var courses = context.Courses.Where(c => c.Price > 3000);
//    Console.WriteLine(" ======= sql =======");

//    Console.WriteLine(courses.ToQueryString());
//    Console.WriteLine(" ======= result =======");
//    foreach (var course in courses)
//    {
//    Console.WriteLine($"course name: {course?.CourseName},{course?.Price.ToString()} ");

//    }


//}
#endregion


#region filteration and projection
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        using (var context = new AppDbContext())
//        {
//            var courseId = 1;
//            var result = context.Sections.Where(s => s.CourseId == courseId)
//                .Select(s => new
//                {
//                    s.Id,
//                   SectionName= s.SectionName.Substring(0,4),
//                    TotalDays = CalculateTotalDays(s.DateRange.StartDate, s.DateRange.EndDate),
//                });
//            Console.WriteLine(" ======= sql =======");
//            /*
//             DECLARE @__courseId_0 int = 1;

//            SELECT [s].[Id], [s].[SectionName], [s].[StartDate], [s].[EndDate]
//            FROM [Sections] AS [s]
//            WHERE [s].[CourseId] = @__courseId_0
//            */

//            Console.WriteLine(result.ToQueryString());
//            Console.WriteLine(" ======= result =======");
//            foreach (var section in result)
//            {
//                Console.WriteLine($"{section.Id}, {section.SectionName} ({section.TotalDays})");

//            }


//        }


//    }
//    private static int CalculateTotalDays(DateOnly startDate, DateOnly endDate)
//    {
//        return endDate.DayNumber - startDate.DayNumber;
//    }
//}
#endregion

#region tracking vs noTracking
//using(var context=new AppDbContext())
//{
//var section = context.Sections.AsNoTracking().FirstOrDefault(s => s.Id == 1);
//section.SectionName = "BlaBla";
//context.SaveChanges();
////data wont be saved
//}
#endregion

#region eagerloading
//using (var context = new AppDbContext())
//{
//    var secId = 1;
//    var sectionQuery = context.Sections.
//        Include(x=>x.Participants);
//    Console.WriteLine(sectionQuery.ToQueryString());
//    var section = sectionQuery.FirstOrDefault(x => x.Id == secId);
//    Console.WriteLine($"section Name: {section.SectionName}");
//    foreach (var participant in section.Participants)
//    {
//        Console.WriteLine($"{participant.Id}- {participant.FName}{participant.LName}");
//    }
//    /*
//     SELECT [s].[Id], [s].[CourseId], [s].[InstructorId], [s].[ScheduleId], [s].[SectionName], [s].[EndDate], [s].[StartDate], [s].[EndTime], [s].[StartTime], [t0].[SectionId], [t0].[ParticipantId], [t0].[Id], [t0].[FName], [t0].[LName], [t0].[Company], [t0].[JobTitle], [t0].[IsIntern], [t0].[University], [t0].[YearOfGraduation], [t0].[Discriminator]
//FROM [Sections] AS [s]
//LEFT JOIN (
//    SELECT [e].[SectionId], [e].[ParticipantId], [t].[Id], [t].[FName], [t].[LName], [t].[Company], [t].[JobTitle], [t].[IsIntern], [t].[University], [t].[YearOfGraduation], [t].[Discriminator]
//    FROM [Enrollments] AS [e]
//    INNER JOIN (
//        SELECT [p].[Id], [p].[FName], [p].[LName], [c].[Company], [c].[JobTitle], [i].[IsIntern], [i].[University], [i].[YearOfGraduation], CASE
//            WHEN [i].[Id] IS NOT NULL THEN N'Individual'
//            WHEN [c].[Id] IS NOT NULL THEN N'Corporate'
//        END AS [Discriminator]
//        FROM [Particpants] AS [p]
//        LEFT JOIN [Coporates] AS [c] ON [p].[Id] = [c].[Id]
//        LEFT JOIN [Individuals] AS [i] ON [p].[Id] = [i].[Id]
//    ) AS [t] ON [e].[ParticipantId] = [t].[Id]
//) AS [t0] ON [s].[Id] = [t0].[SectionId]
//ORDER BY [s].[Id], [t0].[SectionId], [t0].[ParticipantId]
//     */
//}

#endregion
#region eager loading then include
//using (var context = new AppDbContext())
//{
//    var secId = 1;
//    var sectionQuery = context.Sections.
//        Include(x => x.Instructor)
//        .ThenInclude(i => i.Office)
//        .Where(x => x.Id == 1);
//    Console.WriteLine(sectionQuery.ToQueryString());
//    var section = sectionQuery.FirstOrDefault(x => x.Id == secId);
//    Console.WriteLine($"section Name: {section.SectionName},Instructor Name: {section.Instructor.FName},OfficeName: {section.Instructor.Office.OfficeName}");

    /*
  SELECT [s].[Id], [s].[CourseId], [s].[InstructorId], [s].[ScheduleId], [s].[SectionName], [s].[EndDate], [s].[StartDate], [s].[EndTime], [s].[StartTime], [i].[Id], [i].[FName], [i].[LName], [i].[OfficeId], [o].[Id], [o].[OfficeLocation], [o].[OfficeName]
FROM [Sections] AS [s]
LEFT JOIN [Instructors] AS [i] ON [s].[InstructorId] = [i].[Id]
LEFT JOIN [Offices] AS [o] ON [i].[OfficeId] = [o].[Id]
WHERE [s].[Id] = 1
     */
//}

#endregion
#region explicit loading
using (var context = new AppDbContext())
{
    var secId = 1;
    var section = context.Sections.FirstOrDefault(s => s.Id == secId);
    var query = context.Entry(section).Collection(x => x.Participants).Query();
      
    Console.WriteLine(query.ToQueryString());
    
    Console.WriteLine($"section Name: {section.SectionName}");
    foreach (var participant in query)
    {
        Console.WriteLine($"{participant.Id}- {participant.FName}{participant.LName}");
    }
    /*
                 DECLARE @__p_0 int = 1;

            SELECT [t0].[Id], [t0].[FName], [t0].[LName], [t0].[Company], [t0].[JobTitle], [t0].[IsIntern], [t0].[University], [t0].[YearOfGraduation], [t0].[Discriminator], [s].[Id], [t0].[SectionId], [t0].[ParticipantId], [t1].[SectionId], [t1].[ParticipantId], [t1].[Id], [t1].[CourseId], [t1].[InstructorId], [t1].[ScheduleId], [t1].[SectionName], [t1].[EndDate], [t1].[StartDate], [t1].[EndTime], [t1].[StartTime]
            FROM [Sections] AS [s]
            INNER JOIN (
                SELECT [t].[Id], [t].[FName], [t].[LName], [t].[Company], [t].[JobTitle], [t].[IsIntern], [t].[University], [t].[YearOfGraduation], [t].[Discriminator], [e].[SectionId], [e].[ParticipantId]
                FROM [Enrollments] AS [e]
                INNER JOIN (
                    SELECT [p].[Id], [p].[FName], [p].[LName], [c].[Company], [c].[JobTitle], [i].[IsIntern], [i].[University], [i].[YearOfGraduation], CASE
                        WHEN [i].[Id] IS NOT NULL THEN N'Individual'
                        WHEN [c].[Id] IS NOT NULL THEN N'Corporate'
                    END AS [Discriminator]
                    FROM [Particpants] AS [p]
                    LEFT JOIN [Coporates] AS [c] ON [p].[Id] = [c].[Id]
                    LEFT JOIN [Individuals] AS [i] ON [p].[Id] = [i].[Id]
                ) AS [t] ON [e].[ParticipantId] = [t].[Id]
            ) AS [t0] ON [s].[Id] = [t0].[SectionId]
            LEFT JOIN (
                SELECT [e0].[SectionId], [e0].[ParticipantId], [s0].[Id], [s0].[CourseId], [s0].[InstructorId], [s0].[ScheduleId], [s0].[SectionName], [s0].[EndDate], [s0].[StartDate], [s0].[EndTime], [s0].[StartTime]
                FROM [Enrollments] AS [e0]
                INNER JOIN [Sections] AS [s0] ON [e0].[SectionId] = [s0].[Id]
                WHERE [s0].[Id] = @__p_0
            ) AS [t1] ON [t0].[Id] = [t1].[ParticipantId]
            WHERE [s].[Id] = @__p_0
            ORDER BY [s].[Id], [t0].[SectionId], [t0].[ParticipantId], [t0].[Id], [t1].[SectionId], [t1].[ParticipantId]
     */
}

#endregion