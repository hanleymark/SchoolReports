using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SchoolReports.Web.ViewModels.Student
{
    public class StudentEditVM : StudentCreateVM
    {
        public int Id { get; set; }
    }
}
