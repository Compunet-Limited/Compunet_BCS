using System;

namespace Bcs.Models
{
    public class ExamTimeTable
    {
        public int ExamTimeTableId { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ExamStartTime { get; set; }
        public DateTime ExamEndTime { get; set; }
        public string Venue { get; set; }
        public string VenueDetails { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }
        public Course Course { get; set; }
    }

}
