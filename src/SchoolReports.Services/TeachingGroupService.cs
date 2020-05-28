using Microsoft.AspNetCore.Mvc.Rendering;
using ReportWriterData;
using ReportWriterData.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReportWriterService
{
    public class TeachingGroupService : ITeachingGroupService
    {
        private ReportWriterContext _context { get; set; }
        private List<SelectListItem> _teachingGroupsSelectList;

        public List<SelectListItem> TeachingGroupsSelectList
        {
            get
            { return _teachingGroupsSelectList; }
        }

        public TeachingGroupService(ReportWriterContext context)
        {
            _context = context;
            _teachingGroupsSelectList = GetAll().Select(tg => new SelectListItem
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
