using System;
using System.Collections.Generic;
using System.Text;

namespace Bcs.Models
{
    public class Programme
    {
        public int ProgrammeId { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeCode { get; set; }
        public string ProgrammeDescription { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
