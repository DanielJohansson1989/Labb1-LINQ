﻿// <auto-generated />
using Labb1_LINQ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb1_LINQ.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb1_LINQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.CourseContent", b =>
                {
                    b.Property<int>("CourseContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseContentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectByTeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseContentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("SubjectByTeacherId");

                    b.ToTable("CourseContent");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.SubjectTeacherAssociation", b =>
                {
                    b.Property<int>("SubjectTeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectTeacherId"));

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectTeacherId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectTeacherAssociation");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.CourseContent", b =>
                {
                    b.HasOne("Labb1_LINQ.Models.Course", "Course")
                        .WithMany("CourseContent")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1_LINQ.Models.SubjectTeacherAssociation", "SubjectByTeacher")
                        .WithMany("CourseContent")
                        .HasForeignKey("SubjectByTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("SubjectByTeacher");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb1_LINQ.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.SubjectTeacherAssociation", b =>
                {
                    b.HasOne("Labb1_LINQ.Models.Subject", "Subject")
                        .WithMany("SubjectTeacherAssociation")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1_LINQ.Models.Teacher", "Teacher")
                        .WithMany("SubjectTeacherAssociation")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Course", b =>
                {
                    b.Navigation("CourseContent");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Subject", b =>
                {
                    b.Navigation("SubjectTeacherAssociation");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.SubjectTeacherAssociation", b =>
                {
                    b.Navigation("CourseContent");
                });

            modelBuilder.Entity("Labb1_LINQ.Models.Teacher", b =>
                {
                    b.Navigation("SubjectTeacherAssociation");
                });
#pragma warning restore 612, 618
        }
    }
}
