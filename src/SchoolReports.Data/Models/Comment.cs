using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriterData.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
    }
}
