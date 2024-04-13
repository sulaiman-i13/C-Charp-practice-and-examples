namespace ConsoleApp.EF.Migrations.Entities
{
    public class Enrollment
    {
       
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int SectionId { get; set; }
        public Section Section { get; set; } = null!;
    }
}
