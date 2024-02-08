Console.WriteLine("=================Enums===================");

string today = DateTime.Now.DayOfWeek.ToString();

if (Enum.IsDefined(typeof(Dates), today))
{
	Console.WriteLine($"today is :{Enum.Parse(typeof(Dates), today)}");
	Console.WriteLine($"today value is :{(int)(Enum.Parse(typeof(Dates), today))}");
}
Console.WriteLine("_________________________________________");
if (Enum.TryParse(today,out Dates date))
{
    Console.WriteLine($"today is: {date}");
    Console.WriteLine($"today value is: {(int)date}");

}

Console.WriteLine("_________________________________________");

foreach (var item in Enum.GetNames(typeof(Dates)))
{
    Console.WriteLine($"{item} => {(int)Enum.Parse<Dates>(item)}");
}
Console.WriteLine("_________________________________________");

foreach (var item in Enum.GetValues(typeof(Dates)))
{
    Console.WriteLine($"{(int)item} => {(Dates)item}");
}
var day = Dates.Saturday|Dates.Friday;
Console.WriteLine($"-----------------------------------------------------");
Console.WriteLine($"day is weekend ? {day.HasFlag(Dates.WeekEnd)}");
Console.WriteLine($"day is workday ? {day.HasFlag(Dates.WorkDay)}");



[Flags]
public enum Dates
{
	Saturday = 00000000,
	Sunday = 00000001,
	Monday = 00000010,
	Tuseday = 00000100,
	Wednesday = 00001000,
	Thursday = 00010000,
	Friday = 00100000,
	WeekEnd = Saturday | Friday,
	WorkDay = Sunday | Monday | Tuseday | Wednesday | Thursday
}