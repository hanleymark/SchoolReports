using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolReports.Data;
using SchoolReports.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolReports.Services
{
    public class TeachingGroupService : ITeachingGroupService
    {
        private ReportWriterContext  _context { get; set; }

        public List<SelectListItem> TeachingGroupsSelectList { get; }

        public int NumberOfRecords => _context.TeachingGroups.Count();

        public TeachingGroupService(ReportWriterContext context)
        {
            _context = context;
            TeachingGroupsSelectList = GetAll().Select(tg => new SelectListItem
            {
                Value = tg.Id.ToString(),
                Text = tg.Name
            }).ToList();
        }

        public void Add(TeachingGroup newTeachingGroup)
        {
            _context.Add(newTeachingGroup);
        }

        public IEnumerable<TeachingGroup> GetAll()
        {
            return _context.TeachingGroups;
        }

        public TeachingGroup GetById(int id)
        {
            return _context.TeachingGroups.FirstOrDefault(tg => tg.Id == id);
        }
    }
}
