using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
