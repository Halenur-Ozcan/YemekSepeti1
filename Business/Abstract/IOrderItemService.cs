using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderItemService
    {
        List<OrderItem> GetAll();
        OrderItem GetById(int id);
        void Add(OrderItem orderItem);
        void Update(OrderItem orderItem);
        void Delete(int id);
    }
}
