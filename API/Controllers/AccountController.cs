using Business.Abstract;
using DTO.Account;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController:ControllerBase
    {
        private readonly IAccountService _service;
        public AccountController(IAccountService service)
        {
            _service = service;
        }
        //Printing all accounts
        [HttpGet]
        public IActionResult GetAllAccounts()
        {
            var data = _service.GetAll();
            return Ok(data);
        }
        //Search an account by its 'AccountId'
        [HttpGet("{id}")]
        public IActionResult GetAccountById(int id)
        {
            var response = _service.GetByAccountId(id);
            return Ok(response);
        }
        //Create a new account
        [HttpPost]
        public IActionResult Post(CreateAccountRequest request)
        {
            var response = _service.Insert(request);
            return Ok(response);
        }

        //Change customerId for account if exists
        [HttpPut("{Id}")]
        public IActionResult Update(int Id, UpdateAccountRequest request)
        {
            var response = _service.Update(Id, request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var response = _service.Delete(Id);
            return Ok(response);
        }

    }
}
