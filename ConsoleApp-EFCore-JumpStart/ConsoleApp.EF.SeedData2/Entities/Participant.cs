namespace ConsoleApp.EF.Migrations.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
    public class Individual : Participant
    {
        public string University { get; set; } = null!;
        public int YearOfGraduate { get; set; }
        public bool IsEntern { get; set; }
    } 
    public class Corporate : Participant
    {
        public string Company { get; set; } = null!;
        public string JobTitle { get; set; } = null!;

    }
}
