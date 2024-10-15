using Business.Abstract;

using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetList();
        }

        public Order GetById(int id)
        {
            return _orderDal.Get(o => o.Id == id);
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }

        public void Delete(int id)
        {
            var order = _orderDal.Get(o => o.Id == id);
            _orderDal.Delete(order);
        }

        List<Order> IOrderService.GetAll()
        {
            throw new NotImplementedException();
        }

        Order IOrderService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IOrderService.Add(Order order)
        {
            throw new NotImplementedException();
        }

        void IOrderService.Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
