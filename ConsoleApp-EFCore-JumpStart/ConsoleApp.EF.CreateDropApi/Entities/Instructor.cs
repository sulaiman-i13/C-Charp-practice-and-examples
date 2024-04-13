using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF.Migrations.Entities
{
    public  class Instructor
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public int OfficeId { get; set; }
        public Office? Office { get; set; }
        public ICollection<Section> Sections { get; set; }

    }
}
