namespace owm.core.Models
{
    public partial class Order: BaseEntity
    {
        public Order()
        {
            Items = new HashSet<OrderItem>();
        }

        public ICollection<OrderItem> Items { get; set; }
    }
}
