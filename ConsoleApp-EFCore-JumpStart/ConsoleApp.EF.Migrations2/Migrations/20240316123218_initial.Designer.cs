﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp.EF.Migrations2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240316123218_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Enrollment", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique();

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Sections", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Enrollment", b =>
                {
                    b.HasOne("ConsoleApp.EF.Migrations.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp.EF.Migrations.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Instructor", b =>
                {
                    b.HasOne("ConsoleApp.EF.Migrations.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("ConsoleApp.EF.Migrations.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Section", b =>
                {
                    b.HasOne("ConsoleApp.EF.Migrations.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp.EF.Migrations.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.HasOne("ConsoleApp.EF.Migrations.Entities.Schedule", "Schedule")
                        .WithMany("Sections")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ConsoleApp.EF.Migrations.Entities.Schedule", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
