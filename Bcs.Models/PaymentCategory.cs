using System.Collections.Generic;

namespace Bcs.Models
{
    public class PaymentCategory
    {
        public int PaymentCategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<PaymentType> PaymentTypes { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }
        public ICollection<PaymentSetting> PaymentSettings { get; set; }


    }
}