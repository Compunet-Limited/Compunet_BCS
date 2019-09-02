namespace Bcs.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public int SessionId { get; set; }
        public string StudentNumber { get; set; }
        public string BcsReferenceNumber { get; set; }
        public string GetFullName() => $"{LastName} {FirstName} {OtherNames}";
        public Session AdmittedSession { get; set; }
    }

    public class Staff : Person
    {
        public int StaffId { get; set; }
        public string StaffNumber { get; set; }
    }
}
