using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReportWriter.Models.Student;
using ReportWriterData;

namespace ReportWriter.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private ITeachingGroupService _teachingGroupService;

        public StudentController(
            IStudentService studentService,
            ITeachingGroupService teachingGroupService)
        {
            _studentService = studentService;
            _teachingGroupService = teachingGroupService;
        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Student List";
            var studentList = _studentService.GetAll();

            var listingResult = studentList.Select(s => new StudentListItemViewModel
            {
                Id = s.Id,
                Name = $"{s.Forename} {s.Surname}",
                Gender = s.Gender == 'M' ? "Male" : "Female",
                DOB = s.DOB.ToString("d"),
                TeachingGroup = s.TeachingGroup.Name
            }).ToList();

            var studentsListView = new StudentListingViewModel
            {
                Students = listingResult
            };

            return View(studentsListView);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);

            var studentEditViewModel = new StudentEditViewModel
            {
                Id = student.Id,
                Forename = student.Forename,
                Surname = student.Surname,
                Gender = student.Gender,
                DOB = student.DOB,
                TeachingGroup = student.TeachingGroup,
                SelectList = _teachingGroupService.TeachingGroupsSelectList,
                Genders = new List<SelectListItem>()
                {
                    new SelectListItem {
                        Value="M",
                        Text="Male"
                    },
                    new SelectListItem {
                        Value="F",
                        Text="Female"
                    }
                }
            };
            return View(studentEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentEditViewModel studentEditViewModel)
        {
            ModelStateDictionary modelState = ModelState;
            if (modelState.IsValid)
            {
                RedirectToAction("Edit");

                var student = _studentService.GetById(studentEditViewModel.Id);

                student.Forename = studentEditViewModel.Forename;
                student.Surname = studentEditViewModel.Surname;
                student.DOB = studentEditViewModel.DOB;
                student.TeachingGroup = _teachingGroupService
                    .GetById(studentEditViewModel.TeachingGroup.Id);
                student.Gender = studentEditViewModel.Gender;

                _studentService.UpdateAndSave(student);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }
    }
}
