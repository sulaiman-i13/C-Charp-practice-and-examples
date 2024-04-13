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
            builder.HasData(SeedData.LoadOffices());


        }
    }
}
