using System;
using System.Collections.Generic;
using System.Text;

namespace Bcs.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int ProgrammeId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Description { get; set; }
        public Programme Programme { get; set; }
    }
}
