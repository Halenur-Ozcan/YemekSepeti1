using Business.Abstract;
using Core.Entities.Concrete;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _addressService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _addressService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(Address address)
        {
            _addressService.Add(address);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Address address)
        {
            _addressService.Update(address);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _addressService.Delete(id);
            return Ok();
        }
    }
}