using Microsoft.EntityFrameworkCore;
using SchoolReports.Data;
using SchoolReports.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SchoolReports.Services
{
    public class StudentService : IStudentService
    {
        private readonly ReportWriterContext _context;

        public StudentService(ReportWriterContext context)
        {
            _context = context;
        }

        public int NumberOfRecords => _context.Students.Count();

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

        public void Update(Student student)
        {
            _context.Update(student);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
