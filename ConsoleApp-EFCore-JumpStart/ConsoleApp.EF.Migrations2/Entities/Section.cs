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
       public TimeSlot TimeSlot { get; set; }
        public int ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public override string ToString()
        {
            return $"{StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
        }
    }
}