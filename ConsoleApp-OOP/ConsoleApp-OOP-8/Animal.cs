using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_OOP_8
{
	 abstract class Animal
	{
		protected Animal(int id, string name)
		{
			Id = id;
			Name = name;
		}

		protected int Id { get; set; }
		protected string Name { get; set; }

		public abstract void Move();
    }

}
