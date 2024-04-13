using ConsoleApp.EF.Migrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.Migrations.Data.Configuration
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();
            builder.Property(x => x.LName)
                .HasColumnType("varchar").
                HasMaxLength(50).IsRequired();

            //builder.HasDiscriminator<string>("ParticipantType")
            //    .HasValue<Individual>("INDV")
            //    .HasValue<Coporate>("COPR")
            //    ;
            //builder.Property("ParticipantType")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(4);
            //builder.UseTptMappingStrategy();

            //builder.ToTable("Participants");


        }
    }
}

