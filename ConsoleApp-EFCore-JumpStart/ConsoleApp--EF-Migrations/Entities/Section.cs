﻿namespace ConsoleApp.EF.Migrations.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();

    }
}
