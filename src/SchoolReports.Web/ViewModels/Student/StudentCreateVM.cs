using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolReports.Data;
using SchoolReports.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolReports.Web.ViewModels.Student
{
    public class StudentCreateVM
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Forename { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public char Gender { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public TeachingGroup TeachingGroup { get; set; }

        public SelectList TeachingGroupSelectList { get; set; }

        public SelectList Genders { get; set; }
    }
}
