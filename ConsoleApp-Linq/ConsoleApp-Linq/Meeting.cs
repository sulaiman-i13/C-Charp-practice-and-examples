using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Linq
{
	public class Meeting
	{
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartAt { get; set; }
        public TimeOnly EndAt { get; set; }
        public List<Employee> Participants { get; set; } = [];
		public override string ToString()
		{
			var participants=string.Empty;
			foreach (var item in Participants)
			{
				participants += "\t-- "+item + ".\n";
			}
			return $"""
					{Title}.
					from {StartAt} to {EndAt} of {Date}.
					Participants:
					{participants}	
					""";
		}
	}
}
