﻿
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
       
        List<Order> GetOrdersWithDetails();
    }
}
