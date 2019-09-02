using System;

namespace Bcs.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string StateOfOrigin { get; set; }
        public string Lga { get; set; }
        public byte Passport { get; set; }
    }
}
