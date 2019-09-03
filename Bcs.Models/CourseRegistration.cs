using System;

namespace Bcs.Models
{
    public class CourseRegistration
    {
        public int CourseRegistrationId { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public bool IsTraining { get; set; }
        public bool IsExam { get; set; }
        public DateTime TrainingRegDate { get; set; }
        public DateTime? ExamRegDate { get; set; }
        public bool IsApproved { get; set; }
        public Course Course { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }
    }

}
