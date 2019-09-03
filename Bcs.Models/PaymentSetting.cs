namespace Bcs.Models
{
    public class PaymentSetting
    {
        public int PaymentSettingId { get; set; }
        public int PaymentCategoryId { get; set; }
        public int BatchId { get; set; }
        public int SessionId { get; set; }
        public double Discount { get; set; }
        public bool ApplyDiscount { get; set; }
        public bool ConsiderNationality { get; set; }
        public Batch Batch { get; set; }
        public Session Session { get; set; }
        public PaymentCategory PaymentCategory { get; set; }

    }

}
