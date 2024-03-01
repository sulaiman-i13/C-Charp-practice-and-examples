using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp_Linq
{
	public static class MeetingHelper
	{
		public static List<Meeting> All => new List<Meeting>()
		{
	new Meeting()
		{
			Title = "Meeting 1",
		Date = new DateOnly(2024, 2, 28),
		StartAt = new TimeOnly(7, 00),
		EndAt = new TimeOnly(9, 00),
		Participants = EmployeeHelper.Randomize(5).ToList()
	},
	new Meeting()
		{
			Title = "Meeting 2",
		Date = new DateOnly(2024, 2, 28),
		StartAt = new TimeOnly(7, 00),
		EndAt = new TimeOnly(9, 00),
		Participants = EmployeeHelper.Randomize(5).ToList()
	},
	new Meeting()
		{
			Title = "Meeting 3",
		Date = new DateOnly(2024, 1, 28),
		StartAt = new TimeOnly(4, 00),
		EndAt = new TimeOnly(6, 00),
		Participants = EmployeeHelper.Randomize(5).ToList()
	},
	new Meeting()
		{
			Title = "Meeting 4",
		Date = new DateOnly(2024, 3, 20),
		StartAt = new TimeOnly(1, 00),
		EndAt = new TimeOnly(3, 00),
		Participants = EmployeeHelper.Randomize(5).ToList()
	},
	new Meeting()
		{
			Title = "Meeting 5",
		Date = new DateOnly(2024, 1, 18),
		StartAt = new TimeOnly(5, 00),
		EndAt = new TimeOnly(7, 00),
		Participants = EmployeeHelper.Randomize(5).ToList()
	},
		new Meeting()
		{
			Title = "Meeting 6",
		Date = new DateOnly(2024, 2, 10),
		StartAt = new TimeOnly(2, 00),
		EndAt = new TimeOnly(4, 00),
		Participants = EmployeeHelper.Randomize(5).ToList()
	},


};
	}
}
