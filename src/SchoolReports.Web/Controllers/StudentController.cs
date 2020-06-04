using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolReports.Data;
using SchoolReports.Data.Models;
using SchoolReports.Web.ViewModels.Student;

namespace SchoolReports.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private ITeachingGroupService _teachingGroupService;
        private IStudentPageHelperService _studentPageHelperService;

        public StudentController(
            IStudentService ss,
            ITeachingGroupService tgs,
            IStudentPageHelperService sphs)
        {
            _studentService = ss;
            _teachingGroupService = tgs;
            _studentPageHelperService = sphs;
        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Student List";
            var studentList = _studentService.GetAll();

            var listingResult = studentList.Select(s => new StudentListItemVM()
            {
                Id = s.Id,
                FullName = $"{s.Forename} {s.Surname}",
                Gender = s.Gender == 'M' ? "Male" : "Female",
                DOB = s.DOB.ToString("d"),
                TeachingGroup = s.TeachingGroup.Name
            }).ToList();

            var studentsListView = new StudentListingModel
            {
                Students = listingResult
            };

            return View(studentsListView);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                RedirectToAction("Edit");

            var student = _studentService.GetById(id.Value);

            var studentEditViewModel = new StudentEditVM()
            {
                Id = student.Id,
                Forename = student.Forename,
                Surname = student.Surname,
                Gender = student.Gender,
                DOB = student.DOB,
                TeachingGroup = student.TeachingGroup,
                Genders = _studentPageHelperService.GenderSelectList,
                TeachingGroupSelectList = _studentPageHelperService.TeachingGroupSelectList
            };
            return View(studentEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentEditVM studentEditViewModel)
        {
            ModelStateDictionary modelState = ModelState;
            if (modelState.IsValid)
            {

                var student = _studentService.GetById(studentEditViewModel.Id);

                student.Forename = studentEditViewModel.Forename;
                student.Surname = studentEditViewModel.Surname;
                student.DOB = (DateTime) studentEditViewModel.DOB;
                student.TeachingGroup = _teachingGroupService
                    .GetById(studentEditViewModel.TeachingGroup.Id);
                student.Gender = studentEditViewModel.Gender;

                _studentService.Update(student);
                _studentService.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentCreateVM studentCreateModel)
        {
            ModelStateDictionary modelState = ModelState;
            if (modelState.IsValid)
            {
                var student = new Student();

                student.Forename = studentCreateModel.Forename;
                student.Surname = studentCreateModel.Surname;
                student.DOB = (DateTime)studentCreateModel.DOB;
                student.TeachingGroup = _teachingGroupService
                    .GetById(studentCreateModel.TeachingGroup.Id);
                student.Gender = studentCreateModel.Gender;

                _studentService.Add(student);
                _studentService.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }
    }
}
