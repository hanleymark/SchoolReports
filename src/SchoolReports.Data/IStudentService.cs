using SchoolReports.Data.Models;
using System.Collections.Generic;

namespace SchoolReports.Data
{
    public interface IStudentService
    {
        int NumberOfRecords { get; }
        IEnumerable<Student> GetAll();
        Student GetById(int Id);
        void Add(Student newStudent);
        void Update(Student student);
        int SaveChanges();
    }
}
