using System.Collections.Generic;

namespace Bcs.Models
{
    public class Batch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public string BatchDescription { get; set; }
        public ICollection<PaymentType> PaymentTypes { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }
        public ICollection<PaymentSetting> PaymentSettings { get; set; }
        public ICollection<StudentResult> StudentResult { get; set; }
        public ICollection<ExamTimeTable> ExamTimeTables { get; set; }
        public ICollection<CourseRegistration> CourseRegistrations { get; set; }



    }
}
