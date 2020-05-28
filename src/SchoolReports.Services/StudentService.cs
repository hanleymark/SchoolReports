using Microsoft.EntityFrameworkCore;
using ReportWriterData;
using ReportWriterData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ReportWriterService
{
    public class StudentService : IStudentService
    {
        private readonly ReportWriterContext _context;

        public StudentService(ReportWriterContext context)
        {
            _context = context;
        }

        public void Add(Student newStudent)
        {
            _context.Add(newStudent);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.Include(s => s.TeachingGroup);
        }

        public Student GetById(int Id)
        {
            return GetAll()
                .FirstOrDefault(student => student.Id == Id);
        }

        public int UpdateAndSave(Student student)
        {
            _context.Update(student);

            return _context.SaveChanges();
        }
    }
}
