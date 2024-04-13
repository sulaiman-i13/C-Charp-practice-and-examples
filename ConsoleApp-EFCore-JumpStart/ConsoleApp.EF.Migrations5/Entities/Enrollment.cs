namespace ConsoleApp.EF.Migrations.Entities
{
    public class Enrollment
    {
       
        public int ParticipantId { get; set; }
        public Participant Participant { get; set; } = null!;
        public int SectionId { get; set; }
        public Section Section { get; set; } = null!;
    }
}
