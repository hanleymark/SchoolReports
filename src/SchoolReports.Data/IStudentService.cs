using ReportWriterData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportWriterData
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student GetById(int Id);
        void Add(Student newStudent);
        int UpdateAndSave(Student student);
    }
}
