using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ConsoleApp.EF.QueryData1.Entities;
namespace ConsoleApp.EF.QueryData1.Data.Configuration
{
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
            dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
            dateTime => DateOnly.FromDateTime(dateTime))
        { }
    }
}
