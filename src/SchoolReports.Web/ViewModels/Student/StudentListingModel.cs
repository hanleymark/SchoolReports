using System.Collections.Generic;

namespace SchoolReports.Web.ViewModels.Student
{
    public class StudentListingModel
    {
        public IEnumerable<StudentListItemVM> Students { get; set; }
    }
}
