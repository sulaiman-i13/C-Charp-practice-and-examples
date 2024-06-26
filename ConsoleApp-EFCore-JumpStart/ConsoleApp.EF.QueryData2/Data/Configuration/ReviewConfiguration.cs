﻿using ConsoleApp.EF.QueryData1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.EF.QueryData1.Data.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // builder.Property(x => x.CourseName).HasMaxLength(255); // nvarchar(255)



            builder.HasOne(x => x.Course)
                .WithMany(x => x.Reviews)
                .HasForeignKey(x => x.CourseId)
                .IsRequired();

            builder.Property(p => p.CreatedAt).IsRequired();

            builder.ToTable("Reviews");
        }
    }
}
