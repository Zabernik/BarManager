using Domain.Enums;

namespace Domain.Entities
{
    public class Table
    {
        public int TableNumber { get; set; }
        public Order CurrentOrder { get; set; }
        public Status Status { get; set; }
    }
}
