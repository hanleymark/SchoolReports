using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolReports.Data.Models
{
    public class Report
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
