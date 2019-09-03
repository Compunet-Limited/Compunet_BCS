using System;
using System.ComponentModel.DataAnnotations;

namespace Bcs.Models
{
    public class StudentPayment
    {
        public int StudentPaymentId { get; set; }
        public int? StudentId { get; set; }

        [UniqueKey(groupId: "1", order: 0)]
        [StringLength(30, MinimumLength = 1)]
        public string PaymentReferenceNo { get; set; }
        public int PaymentCategoryId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public double Amount { get; set; }
        public bool IsPayed { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public Student Student { get; set; }
        public PaymentCategory PaymentCategory { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }

    }

}
