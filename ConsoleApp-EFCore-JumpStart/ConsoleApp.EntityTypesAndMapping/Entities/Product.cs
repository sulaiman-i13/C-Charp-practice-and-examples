

using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.EntityTypesAndMapping.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }
        //[NotMapped]
        //public SnapShot SnapShot { get; set; } = new();
    }
}
