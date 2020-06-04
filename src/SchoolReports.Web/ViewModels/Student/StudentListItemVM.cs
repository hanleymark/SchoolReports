using SchoolReports.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolReports.Web.ViewModels.Student
{
    public class StudentListItemVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string TeachingGroup { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
    }
}
