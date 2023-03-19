﻿// <auto-generated />
using System;
using KUSYS_Demo.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KUSYS_Demo.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230317214703_newMig")]
    partial class newMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KUSYS_Demo.Models.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = "CSI101",
                            CourseName = "Introduction to Computer Science"
                        },
                        new
                        {
                            CourseId = "CSI102",
                            CourseName = "Algorithms"
                        },
                        new
                        {
                            CourseId = "MAT101",
                            CourseName = "Calculus"
                        },
                        new
                        {
                            CourseId = "PHY101",
                            CourseName = "Physics"
                        });
                });

            modelBuilder.Entity("KUSYS_Demo.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BirthDate = new DateTime(1998, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Halil",
                            LastName = "Kakut"
                        },
                        new
                        {
                            StudentId = 2,
                            BirthDate = new DateTime(1993, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "ibrahim",
                            LastName = "yılmaz"
                        },
                        new
                        {
                            StudentId = 3,
                            BirthDate = new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "erdi",
                            LastName = "süzen"
                        },
                        new
                        {
                            StudentId = 4,
                            BirthDate = new DateTime(1991, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "serdal",
                            LastName = "bilgin"
                        });
                });

            modelBuilder.Entity("KUSYS_Demo.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = "PHY101",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = "MAT101",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseId = "MAT101",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseId = "MAT101",
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("KUSYS_Demo.Models.StudentCourse", b =>
                {
                    b.HasOne("KUSYS_Demo.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KUSYS_Demo.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("KUSYS_Demo.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("KUSYS_Demo.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}