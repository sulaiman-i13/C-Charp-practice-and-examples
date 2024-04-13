using ConsoleApp.EF.Migrations.Entities;
using ConsoleApp.EF.Migrations2.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.Migrations.Data.Configuration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever();
            builder.Property(x => x.Title)
                .HasConversion(
                x => x.ToString(),
                x => (SchedulEnums)Enum.Parse(typeof(SchedulEnums), x)
                );
            builder.ToTable("Schedules");
            builder.HasData(SeedData.LoadSchedules());


        }
    }
}


