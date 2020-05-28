using ReportWriterData.Models;
using System;

namespace ReportWriter.Models.Student
{
    public class StudentListItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string TeachingGroup { get; set; }
    }
}
