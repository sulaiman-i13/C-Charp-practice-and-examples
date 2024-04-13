using ConsoleApp.EF.Migrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.Migrations.Data.Configuration
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.OfficeName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();
            builder.Property(x => x.OfficeLocation)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();

            builder.ToTable("Offices");

            builder.HasData(LoadOffices());
        }

        private static List<Office> LoadOffices()
        {
            return new List<Office>
            {
               new Office{Id=1,OfficeName="Office #1",OfficeLocation="OfficeLocation #1"},
               new Office{Id=2,OfficeName="Office #2",OfficeLocation="OfficeLocation #2"},
               new Office{Id=3,OfficeName="Office #3",OfficeLocation="OfficeLocation #3"},
               new Office{Id=4,OfficeName="Office #4",OfficeLocation="OfficeLocation #4"},
               new Office{Id=5,OfficeName="Office #5",OfficeLocation="OfficeLocation #5"},
            };
        }
    }
}
