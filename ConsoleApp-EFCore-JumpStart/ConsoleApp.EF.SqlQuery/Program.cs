using ConsoleApp.EF.QueryData1.Data;
using ConsoleApp.EF.QueryData1.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
#region fromsql
//using (var context=new AppDbContext())
//{
//    var courses = context.Courses.FromSql($"select * from dbo.courses");
//    var coursesv2 = context.Courses.FromSqlInterpolated($"select * from dbo.courses");
//    var coursesv3 = context.Courses.FromSqlRaw($"select * from dbo.courses");
//	foreach (var item in coursesv3)
//	{
//        Console.WriteLine($"{item.CourseName } {item.Price }");
//    }
//}

#endregion

#region Find,firstOrDefault,SingleOrDefault

//using (var context = new AppDbContext())
//{
//    var courseId = 1;
//    var findCourse = context.Courses.Find(courseId);
//    Console.WriteLine(findCourse.CourseName);

//    var firstCourse = context.Courses.FirstOrDefault(c=>c.Id== courseId);
//    Console.WriteLine(firstCourse.CourseName);


//    var singleCourse = context.Courses.SingleOrDefault(c => c.Id == courseId);
//    Console.WriteLine(singleCourse.CourseName);

//}

#endregion

#region Sql With Pararmeter
//using (var context=new AppDbContext())
//{
//    var course = context.Courses.FromSqlRaw("select * from courses where id = @courseId", new SqlParameter("@courseId", 1)).FirstOrDefault();

//    Console.WriteLine(course.CourseName+"  =>  "+course.HoursToComplete);
//}

#endregion
#region stored procedure
//using (var context = new AppDbContext())
//{

//    var startDate = new SqlParameter("@StartDate", System.Data.SqlDbType.Date)
//    {
//        Value = "2023-01-01"
//    };
//    var endDate = new SqlParameter("@EndDate", System.Data.SqlDbType.Date)
//    {
//        Value = "2023-06-01"
//    };
//    var sectionDetails = context
//        .SectionDetails
//        .FromSql($"Exec dbo.sp_GetSectionWithninDateRange {startDate}, {endDate}").ToList();

//    foreach(var sec in sectionDetails) Console.WriteLine(sec);

//}

#endregion
#region views

//using (var context = new AppDbContext())
//{

//    var courseOverviews = context.CourseOverviews.ToList();

//    foreach (var cov in courseOverviews) Console.WriteLine(cov);

//}
#endregion

#region use scaler function

//using (var context=new AppDbContext())
//{
//    var startdate = new DateTime(2023, 01, 01);
//    var enddate = new DateTime(2023, 02, 01);
//    var startTime = new TimeSpan(08, 00, 00);
//    var endTime = new TimeSpan(10, 00, 00);

//    var result = context.Instructors.Select(i => new {
//    Id=i.Id,
//    name=i.FName+" "+i.LName,
//    DateRange=$"{startdate.ToShortDateString()} - {enddate.ToShortDateString()}",
//    timeRange=$"{startTime.ToString("hh\\:mm")} - {endTime.ToString("hh\\:mm")}",
//    status=AppDbContext.GetInstructorAvailability(i.Id,startdate,enddate,startTime,endTime)
//    }).ToList();

//    foreach (var item in result)
//    {
//        Console.WriteLine(
//            $"{item.Id}\t{item.name,-20}\t{item.DateRange}\t{item.timeRange}\t{item.status}");
//    }
//}
#endregion


#region use tablevalued function

//using (var context = new AppDbContext())
//{

//    var result = context.GetSectionsExceedingParticipantCount(10);

//    foreach (var item in result)
//    {
//        Console.WriteLine($"{item.SectionName,-20}");
//    }
//}
#endregion
#region use global filteration function

using (var context = new AppDbContext())
{

    var result = context.Sections.ToList();

    foreach (var item in result)
    {
        Console.WriteLine($"{item.SectionName,-20}  {item.DateRange.StartDate}");
    }
}
#endregion