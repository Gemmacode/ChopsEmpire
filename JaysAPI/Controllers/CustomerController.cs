using JaysCore.Service;
using JaysData.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JaysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpPost("Create Customer")]
        public IActionResult CreateNewCustomer(CreateCustomerDTO dto)
        {
            _customerRepo.CreateCustomer(dto);
            return Ok("Customer-Created-Successfully");
        }

        [HttpGet("Get Customer by Id")]
        public IActionResult GetCustomer(string CustomerId)
        {
            var customer = _customerRepo.GetCustomerById(CustomerId);
            return Ok(customer);
        }

        [HttpDelete("Delete customer")]

        public IActionResult DeleteGetCustomer(string CustomerId)
        {
            _customerRepo.DeleteCustomerById(CustomerId);
            return Ok("Customer Deleted Successfully");
        }

       




    }
}
