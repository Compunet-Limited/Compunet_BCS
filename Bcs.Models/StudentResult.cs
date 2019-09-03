namespace Bcs.Models
{
    public class StudentResult
    {
        public int StudentResultId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public string Grade { get; set; }
        public string Remark { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }
    }

}
