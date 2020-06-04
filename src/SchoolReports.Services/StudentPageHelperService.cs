using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolReports.Data;
using SchoolReports.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SchoolReports.Services
{
    public class StudentPageHelperService : IStudentPageHelperService
    {
        private ITeachingGroupService _teachingGroupService;

        public StudentPageHelperService(ITeachingGroupService tgs)
        {
            _teachingGroupService = tgs;
        }

        public SelectList GenderSelectList
        {
            get
            {
                return new SelectList(new List<SelectListItem>()
                {
                    new SelectListItem {Value = "M", Text = "Male" },
                    new SelectListItem {Value = "F", Text = "Female"}
                });
            }
        }

        public SelectList TeachingGroupSelectList
        {
            get
            {
                return new SelectList(_teachingGroupService.GetAll().ToList(),
                    nameof(TeachingGroup.Id),
                    nameof(TeachingGroup.Name));
            }
        }

    }
}
