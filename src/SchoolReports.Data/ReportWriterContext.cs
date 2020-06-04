using Microsoft.EntityFrameworkCore;
using SchoolReports.Data.Models;
using System;

namespace SchoolReports.Data
{
    public class ReportWriterContext : DbContext
    {
        public ReportWriterContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeachingGroup> TeachingGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeachingGroup>().HasData(
                new
                {
                    Id = 1,
                    Name = "6MH"
                },
                new
                {
                    Id = 2,
                    Name = "6GI"
                }
            );

            modelBuilder.Entity<Student>().HasData(
                new { Id = 1, Forename = "Mark", Surname = "Hanley", Gender = 'M', TeachingGroupId = 1, DOB = DateTime.Parse("1970/10/23") },
                new { Id = 2, Forename = "Veronica", Surname = "Hanley", Gender = 'F', TeachingGroupId = 1, DOB = DateTime.Parse("1978/12/13") },
                new { Id = 3, Forename = "Nicky", Surname = "Manosalvas", Gender = 'F', TeachingGroupId = 1, DOB = DateTime.Parse("2001/2/5") },
                new { Id = 4, Forename = "Seb", Surname = "Manolsalvas", Gender = 'M', TeachingGroupId = 1, DOB = DateTime.Parse("2003/2/4") },
                new { Id = 5, Forename = "Sammy", Surname = "Hanley", Gender = 'M', TeachingGroupId = 1, DOB = DateTime.Parse("2012/12/19") },
                new { Id = 6, Forename = "Noah", Surname = "Hanley", Gender = 'M', TeachingGroupId = 1, DOB = DateTime.Parse("2018/7/22") });
        }
    }
}
