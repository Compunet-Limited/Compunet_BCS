using System;
using System.Collections.Generic;
using System.Text;

namespace Bcs.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public bool ActiveSession { get; set; }
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
        public ICollection<PaymentType> PaymentTypes { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }
        public ICollection<PaymentSetting> PaymentSettings { get; set; }
        public ICollection<StudentResult> StudentResult { get; set; }
        public ICollection<ExamTimeTable> ExamTimeTables { get; set; }
        public ICollection<CourseRegistration> CourseRegistrations { get; set; }

    }
}
