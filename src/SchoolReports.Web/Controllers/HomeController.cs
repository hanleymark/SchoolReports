using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SchoolReports.Data;

namespace SchoolReports.Web.Controllers
{
    public class HomeController : Controller
    {
        private IStudentService _studentService;
        private ITeachingGroupService _teachingGroupService;

        public HomeController(
            IStudentService studentService,
            ITeachingGroupService teachingGroupService)
        {
            _studentService = studentService;
            _teachingGroupService = teachingGroupService;
        }
        public IActionResult Index()
        {
            var statusMessage = "<p>Entities present:</p>";
            statusMessage += $"<li>{_teachingGroupService.NumberOfRecords} teaching groups</li>";
            statusMessage += $"<li>{_studentService.NumberOfRecords} students</li>";

            ViewBag.Message = statusMessage;

            return View("Index");
        }
    }
}
