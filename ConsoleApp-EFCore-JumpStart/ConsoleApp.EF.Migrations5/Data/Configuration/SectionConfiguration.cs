using ConsoleApp.EF.Migrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.Migrations.Data.Configuration
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.SectionName)
                .HasColumnType("varchar").
                HasMaxLength(255).IsRequired();

            builder.HasOne(s => s.Course)
                .WithMany(c => c.Sections)
                .HasForeignKey(s => s.CourseId)
                .IsRequired();
            builder.HasOne(s => s.Instructor)
                .WithMany(i => i.Sections)
                .HasForeignKey(s => s.InstructorId)
                .IsRequired(false);

            builder.HasOne(s => s.Schedule)
                .WithMany(sch => sch.Sections)
                .HasForeignKey(s=>s.ScheduleId)
                .IsRequired();
            builder.OwnsOne(s => s.TimeSlot,
                ts => { 
                    ts.Property(p => p.StartTime)
                    .HasColumnType("time")
                    .HasColumnName("StartTime"); 
                    ts.Property(p => p.EndTime)
                    .HasColumnType("time")
                    .HasColumnName("EndTime");
                });
        

            builder.HasMany(s => s.Participants)
                .WithMany(st => st.Sections)
                .UsingEntity<Enrollment>();

            builder.ToTable("Sections");

        }

       
    }
}
