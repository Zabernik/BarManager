using Domain.Enums;

namespace Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}
