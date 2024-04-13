using ConsoleApp.EF.Migrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF.Migrations.Data.Configuration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();
            builder.Property(x => x.LName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();

            builder.HasOne(i => i.Office)
                .WithOne(o => o.Instructor)
                .HasForeignKey<Instructor>(i => i.OfficeId)
                .IsRequired(false);
            builder.ToTable("Instructors");

            builder.HasData(LoadInstructors());
        }

        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor{Id=1,FName="Ahmed",LName=" Abdullah",OfficeId=1},
                new Instructor{Id=2,FName="Ahmed",LName=" Fathi",OfficeId=2},
                new Instructor{Id=3,FName="Suliaman",LName="Ali",OfficeId=3},
                new Instructor{Id=4,FName="Monzer",LName="Fares",OfficeId=4},
                new Instructor{Id=5,FName="Wael",LName="Saed",OfficeId=5},
            };
        }
    }
    }

