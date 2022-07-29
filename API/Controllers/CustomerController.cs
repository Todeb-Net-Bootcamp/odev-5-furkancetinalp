using Business.Abstract;
using DTO.Customer;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        //Get all customers and their information
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var data = _service.GetAll();
            return Ok(data);
        }
        //Search customer by its identity number
        [HttpGet("{identityNumber}")]
        public IActionResult GetCustomerByIdentity(string identityNumber)
        {
            var response = _service.GetByIdentity(identityNumber);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult Post(CreateCustomerRequest request)
        {
            var response = _service.Insert(request);
            return Ok(response);
        }

        //Change customer info via identity number
        [HttpPut("{identityNumber}")]
        public IActionResult Update(string identityNumber, UpdateCustomerRequest request)
        {
            var response = _service.Update(identityNumber, request);
            return Ok(response);
        }
        //Delete customer if exists
        [HttpDelete("{identityNumber}")]
        public IActionResult Delete(string identityNumber)
        {
            var response = _service.Delete(identityNumber);
            return Ok(response);
        }

    }
}
