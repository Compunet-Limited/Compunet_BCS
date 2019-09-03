namespace Bcs.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public int PaymentCategoryId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public double Amount { get; set; }
        public string AmountInWords { get; set; }       
        public bool IsForeign { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }
        public PaymentCategory PaymentCategory { get; set; }
    }

}
