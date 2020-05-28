﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReportWriterData;

namespace ReportWriterData.Migrations
{
    [DbContext(typeof(ReportWriterContext))]
    [Migration("20200518223026_SeedTry1")]
    partial class SeedTry1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReportWriterData.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ReportWriterData.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("ReportWriterData.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeachingGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeachingGroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2020, 5, 18, 23, 30, 25, 654, DateTimeKind.Local).AddTicks(4957),
                            Forename = "Abel",
                            Gender = "M",
                            Surname = "Magwitch"
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(2020, 5, 18, 23, 30, 25, 662, DateTimeKind.Local).AddTicks(760),
                            Forename = "Brenda",
                            Gender = "F",
                            Surname = "Micklethwaite"
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(2020, 5, 18, 23, 30, 25, 662, DateTimeKind.Local).AddTicks(913),
                            Forename = "Charlie",
                            Gender = "M",
                            Surname = "Parker"
                        });
                });

            modelBuilder.Entity("ReportWriterData.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ReportWriterData.Models.TeachingGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeachingGroups");
                });

            modelBuilder.Entity("ReportWriterData.Models.Comment", b =>
                {
                    b.HasOne("ReportWriterData.Models.Report", null)
                        .WithMany("Comments")
                        .HasForeignKey("ReportId");

                    b.HasOne("ReportWriterData.Models.Subject", "Subject")
                        .WithMany("Comments")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("ReportWriterData.Models.Report", b =>
                {
                    b.HasOne("ReportWriterData.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("ReportWriterData.Models.Student", b =>
                {
                    b.HasOne("ReportWriterData.Models.TeachingGroup", "TeachingGroup")
                        .WithMany()
                        .HasForeignKey("TeachingGroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
