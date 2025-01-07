using Domain.Enums;

namespace Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TableNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime InitOrderTime { get; set; }
        public DateTime CompletionTime { get; set; }
        public List<OrderItem> Items { get; set; }
        public Status Status { get; set; }
    }
}
