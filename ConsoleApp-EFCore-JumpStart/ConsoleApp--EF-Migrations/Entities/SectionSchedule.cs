namespace ConsoleApp.EF.Migrations.Entities
{
    public class SectionSchedule
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public int SectionId { get; set; }
        public Section? Section { get; set; }
        public int ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }
    }
}
