using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolReports.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Forename { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        public TeachingGroup TeachingGroup { get; set; }
        [Required]
        public DateTime DOB { get; set; }
    }
}
