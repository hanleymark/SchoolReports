using Microsoft.AspNetCore.Mvc.Rendering;
using ReportWriterData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriterData
{
    public interface ITeachingGroupService
    {
        IEnumerable<TeachingGroup> GetAll();
        TeachingGroup GetById(int Id);
        void Add(TeachingGroup newTeachingGroup);
        List<SelectListItem> TeachingGroupsSelectList { get; }
    }
}
