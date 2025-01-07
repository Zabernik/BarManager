namespace Domain.Entities
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; } //change string to enum
        public DateTime Date { get; set; }
    }
}
