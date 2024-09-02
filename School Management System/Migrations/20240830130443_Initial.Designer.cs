﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School_Management_System.Data;

#nullable disable

namespace School_Management_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240830130443_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.Property<int>("ClassesClass_id")
                        .HasColumnType("int");

                    b.Property<int>("StudentsStd_id")
                        .HasColumnType("int");

                    b.HasKey("ClassesClass_id", "StudentsStd_id");

                    b.HasIndex("StudentsStd_id");

                    b.ToTable("StudentClasses", (string)null);
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.Property<int>("Class_id")
                        .HasColumnType("int");

                    b.Property<int>("TeachersT_id")
                        .HasColumnType("int");

                    b.HasKey("Class_id", "TeachersT_id");

                    b.HasIndex("TeachersT_id");

                    b.ToTable("ClassTeacher");
                });

            modelBuilder.Entity("GradeStudent", b =>
                {
                    b.Property<int>("GradesGrd_id")
                        .HasColumnType("int");

                    b.Property<int>("StudentsStd_id")
                        .HasColumnType("int");

                    b.HasKey("GradesGrd_id", "StudentsStd_id");

                    b.HasIndex("StudentsStd_id");

                    b.ToTable("GradeStudent");
                });

            modelBuilder.Entity("School_Management_System.Models.Class", b =>
                {
                    b.Property<int>("Class_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Class_id"));

                    b.Property<int>("Class_number")
                        .HasColumnType("int");

                    b.HasKey("Class_id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("School_Management_System.Models.Grade", b =>
                {
                    b.Property<int>("Grd_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Grd_id"));

                    b.Property<string>("Grd_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Grd_id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("School_Management_System.Models.Login", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Login", (string)null);
                });

            modelBuilder.Entity("School_Management_System.Models.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Register", (string)null);
                });

            modelBuilder.Entity("School_Management_System.Models.Student", b =>
                {
                    b.Property<int>("Std_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Std_id"));

                    b.Property<int>("Std_Age")
                        .HasColumnType("int");

                    b.Property<string>("Std_Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Std_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Std_id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("School_Management_System.Models.Subject", b =>
                {
                    b.Property<int>("Sbj_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sbj_id"));

                    b.Property<string>("Sbj_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sbj_id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("School_Management_System.Models.Teacher", b =>
                {
                    b.Property<int>("T_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("T_id"));

                    b.Property<DateOnly>("Date_of_joining")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int?>("StudentStd_id")
                        .HasColumnType("int");

                    b.Property<string>("Teacher_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("T_id");

                    b.HasIndex("StudentStd_id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("School_Management_System.Models.Term", b =>
                {
                    b.Property<int>("Trm_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Trm_id"));

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Trm_id");

                    b.ToTable("Terms");
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.Property<int>("StudentsStd_id")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsSbj_id")
                        .HasColumnType("int");

                    b.HasKey("StudentsStd_id", "SubjectsSbj_id");

                    b.HasIndex("SubjectsSbj_id");

                    b.ToTable("StudentSubject");
                });

            modelBuilder.Entity("StudentTerm", b =>
                {
                    b.Property<int>("StudentsStd_id")
                        .HasColumnType("int");

                    b.Property<int>("TermsTrm_id")
                        .HasColumnType("int");

                    b.HasKey("StudentsStd_id", "TermsTrm_id");

                    b.HasIndex("TermsTrm_id");

                    b.ToTable("StudentTerm");
                });

            modelBuilder.Entity("SubjectTeacher", b =>
                {
                    b.Property<int>("SubjectSbj_id")
                        .HasColumnType("int");

                    b.Property<int>("TeachersT_id")
                        .HasColumnType("int");

                    b.HasKey("SubjectSbj_id", "TeachersT_id");

                    b.HasIndex("TeachersT_id");

                    b.ToTable("SubjectTeacher");
                });

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.HasOne("School_Management_System.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesClass_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management_System.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStd_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.HasOne("School_Management_System.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("Class_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management_System.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersT_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GradeStudent", b =>
                {
                    b.HasOne("School_Management_System.Models.Grade", null)
                        .WithMany()
                        .HasForeignKey("GradesGrd_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management_System.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStd_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School_Management_System.Models.Teacher", b =>
                {
                    b.HasOne("School_Management_System.Models.Student", null)
                        .WithMany("Teachers")
                        .HasForeignKey("StudentStd_id");
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.HasOne("School_Management_System.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStd_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management_System.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsSbj_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentTerm", b =>
                {
                    b.HasOne("School_Management_System.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStd_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management_System.Models.Term", null)
                        .WithMany()
                        .HasForeignKey("TermsTrm_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubjectTeacher", b =>
                {
                    b.HasOne("School_Management_System.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectSbj_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management_System.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersT_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School_Management_System.Models.Student", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
