// See https://aka.ms/new-console-template for more information
public static class DateTimeHelper
{
	public static bool IsWeekend(this DateTime dateTime)
	{
		if (dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Saturday)
			return true;
		return false;
	}
}