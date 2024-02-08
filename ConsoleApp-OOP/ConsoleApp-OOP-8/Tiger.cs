using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_OOP_8
{
	sealed class Tiger : Animal,IEat
	{
        public new int Id { get; set; }
        public Tiger(int id, string name) : base(id, name)
		{
		}

		public override void Move()
		{
            Console.WriteLine($"{typeof(Tiger)}");
            Console.WriteLine(	"Tiger walks");
		}

		public void IEat()
		{

			Console.WriteLine("Tiger eats");
		}
	}
}
