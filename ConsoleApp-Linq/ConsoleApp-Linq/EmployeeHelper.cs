using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Linq
{
	public static class EmployeeHelper
	{
		private static Random _random = new Random();
		public static List<Employee> All => new List<Employee>()     {
	new Employee{Id=1,Name="sulaiman"},
	new Employee{Id=2,Name="ibrahem"},
	new Employee{Id=3,Name="ahmed"},
	new Employee{Id=4,Name="saleh"},
	new Employee{Id=5,Name="Firas"},
	new Employee{Id=6,Name="tony"},
	new Employee{Id=7,Name="nabil"},
	new Employee{Id=8,Name="fadi"},
};
		public static IEnumerable<Employee> Randomize(int count)
		{
			if (Shuffeld.Count < count) return Shuffeld;
			else return Shuffeld.Take(count);
		}
		public static IEnumerable<Employee> GetRange(IEnumerable<int> range)
		{
			return All.Where((e,i)=>range.Contains(i));
		}

		private static List<Employee> Shuffeld => All.OrderBy(e => _random.Next(0, All.Count)).ToList();

	}
}
