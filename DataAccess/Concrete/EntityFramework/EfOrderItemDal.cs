﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderItemDal : EfEntityRepositoryBase<OrderItem, MyContext>, IOrderItemDal
    {
        // Ek işlevsellik eklemeniz gerekiyorsa buraya ekleyebilirsiniz.
    }
}
