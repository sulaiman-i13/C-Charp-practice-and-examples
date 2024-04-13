namespace ConsoleApp.EF.Migrations.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
}
