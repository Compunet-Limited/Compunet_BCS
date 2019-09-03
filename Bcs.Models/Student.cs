using System.Collections.Generic;

namespace Bcs.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public int SessionId { get; set; }
        public string StudentNumber { get; set; }
        public string BcsReferenceNumber { get; set; }
        public bool IsTrainingCandidate { get; set; }
        public bool IsExamCandidate { get; set; }
        public string GetFullName() => $"{LastName} {FirstName} {OtherNames}";
        public Session AdmittedSession { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }
        public ICollection<StudentResult> StudentResult { get; set; }
    }
}
