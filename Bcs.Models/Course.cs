using System.Collections.Generic;

namespace Bcs.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int ProgrammeId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public Programme Programme { get; set; }
        public ICollection<StudentResult> StudentResult { get; set; }
        public ICollection<ExamTimeTable> ExamTimeTables { get; set; }
    }
}
