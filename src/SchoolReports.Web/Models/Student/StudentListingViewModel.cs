using System.Collections.Generic;

namespace ReportWriter.Models.Student
{
    public class StudentListingViewModel
    {
        public IEnumerable<StudentListItemViewModel> Students { get; set; }
    }
}
