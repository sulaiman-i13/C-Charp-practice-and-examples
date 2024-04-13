﻿using ConsoleApp.EF.Migrations.Entities;
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

        }
    }
    }

