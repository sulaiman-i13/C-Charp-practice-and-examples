using ConsoleApp.EF.SaveData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.SaveData.Data.Config
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FName)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(x => x.LName)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
            builder.ToTable("Authors");
        }
    }
}
