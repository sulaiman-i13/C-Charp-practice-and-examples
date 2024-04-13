using ConsoleApp.EF.Migrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.Migrations.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();
            builder.Property(x => x.LName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();
            builder.ToTable("Students");

        }
    }
    }

