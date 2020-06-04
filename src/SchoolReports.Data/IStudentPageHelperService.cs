using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolReports.Data
{
    public interface IStudentPageHelperService
    {
        SelectList TeachingGroupSelectList { get; }
        SelectList GenderSelectList { get; }
    }
}
