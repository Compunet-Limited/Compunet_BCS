using System;

namespace Bcs.Models
{
    public class TrainingTimeTable
    {
        public int TrainingTimeTableId { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public string DayOfTheWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Venue { get; set; }
        public string VenueDetails { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }
        public Course Course { get; set; }
    }

}
