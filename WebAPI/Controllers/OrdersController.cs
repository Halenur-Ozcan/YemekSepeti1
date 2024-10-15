using Business.Abstract;
using Core.Entities.Concrete;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _orderService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(Order order)
        {
            _orderService.Add(order);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Order order)
        {
            _orderService.Update(order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _orderService.Delete(id);
            return Ok();
        }
    }
}
