﻿using ConsoleApp.EF.QueryData1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleApp.EF.QueryData1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<SectionDetails> SectionDetails { get; set; }
        public DbSet<CourseOverview> CourseOverviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = config.GetSection("ConnectionStrings").GetSection("default").Value;
            //optionsBuilder.UseSqlServer(connectionString).LogTo(Console.WriteLine, LogLevel.Information);            //use no tracking as default:
            //optionsBuilder
            //    .UseSqlServer(connectionString,o=>o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)).LogTo(Console.WriteLine, LogLevel.Information);            //use no tracking as default:
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine, LogLevel.Information);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Course).Assembly);
            modelBuilder.HasDbFunction(typeof(AppDbContext)
                .GetMethod(nameof(GetSectionsExceedingParticipantCount), new[] { typeof(int) }));

        }


        [DbFunction("fn_InstructorAvailability", "dbo")]
        public static string GetInstructorAvailability(int instructorId
            , DateTime startDate
            , DateTime endDate
            , TimeSpan startTime
            , TimeSpan endTime)
        {
            // This doesn't need an implementation; EF core uses the function mapping
            throw new NotImplementedException();
        }

        public IQueryable<Section> GetSectionsExceedingParticipantCount(int participantThreshold)
            => FromExpression(
                () => GetSectionsExceedingParticipantCount(participantThreshold)
                );
    }
}