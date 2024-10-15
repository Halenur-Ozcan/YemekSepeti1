using Business.Abstract;
using Core.Entities.Concrete;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;

        public OrderItemsController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public List<OrderItem> Get()
        {
            return _orderItemService.GetAll();
        }

        [HttpGet("{id}")]
        public OrderItem Get(int id)
        {
            return _orderItemService.GetById(id);
        }
    }
}