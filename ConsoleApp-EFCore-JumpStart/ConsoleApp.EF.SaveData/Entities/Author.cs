using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF.SaveData.Entities
{
    public class Author
    {

        public int Id { get; set; }
        public string   FName { get; set; }
        public string   LName { get; set; }
        public List<Book> Books { get; set; } = new();

    }
}
