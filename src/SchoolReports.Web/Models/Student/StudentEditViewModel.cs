using Microsoft.AspNetCore.Mvc.Rendering;
using ReportWriterData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriter.Models.Student
{
    public class StudentEditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Forename")]
        [Required]
        public string Forename { get; set; }

        [Display(Name = "Surname")]
        [Required]
        public string Surname { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public char Gender { get; set; }
        public List<SelectListItem> Genders;

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "Please enter a valid date of birth.")]
        public DateTime DOB { get; set; }

        [Display(Name = "Teaching group")]
        [Required(ErrorMessage = "Please enter the student's teaching group")]
        public TeachingGroup TeachingGroup { get; set; }
        public List<SelectListItem> SelectList { get; set; }

    }
}
