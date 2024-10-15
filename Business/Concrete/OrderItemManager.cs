using Business.Abstract;

namespace Business.Concrete
{
    // Business/Concrete/OrderItemManager.cs

    using Core.Entities.Concrete;
    using DataAccess.Abstract;
    using System.Collections.Generic;

    namespace Business.Concrete
    {
        public class OrderItemManager : IOrderItemService
        {
            private readonly IOrderItemDal _orderItemDal;

            public OrderItemManager(IOrderItemDal orderItemDal)
            {
                _orderItemDal = orderItemDal;
            }

            public List<OrderItem> GetAll()
            {
                return _orderItemDal.GetList();
            }

            public OrderItem GetById(int id)
            {
                return _orderItemDal.Get(oi => oi.Id == id);
            }

            public void Add(OrderItem orderItem)
            {
                _orderItemDal.Add(orderItem);
            }

            public void Update(OrderItem orderItem)
            {
                _orderItemDal.Update(orderItem);
            }

            public void Delete(int id)
            {
                var orderItem = _orderItemDal.Get(oi => oi.Id == id);
                _orderItemDal.Delete(orderItem);
            }
        }
    }

}
