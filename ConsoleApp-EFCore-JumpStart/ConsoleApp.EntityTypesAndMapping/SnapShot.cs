

//using System.ComponentModel.DataAnnotations.Schema;

//namespace ConsoleApp.EntityTypesAndMapping
//{
//    //[NotMapped]
//    public class SnapShot
//    {
//        public DateTime LoadedAt => DateTime.UtcNow;
//        public string Version => Guid.NewGuid().ToString().Substring(0, 8);
//    }
//    public class AuditEntry
//    {
//        public int Id { get; set; }
//        public string? Action { get; set; }

//        public string? UserName { get; set; }
//    } }