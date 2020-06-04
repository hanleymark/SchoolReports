using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolReports.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolReports.Data
{
    public interface ITeachingGroupService
    {
        int NumberOfRecords { get; }
        IEnumerable<TeachingGroup> GetAll();
        TeachingGroup GetById(int Id);
        void Add(TeachingGroup newTeachingGroup);
    }
}
