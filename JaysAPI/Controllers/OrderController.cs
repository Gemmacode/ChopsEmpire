using JaysCore.Service;
using JaysData.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JaysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo orderRepo;
      
        public OrderController(IOrderRepo orderRepo)
        {
            this.orderRepo = orderRepo;
        }
              
        
        [HttpPost("create Oreder")]


        public IActionResult CreateNewOrder(CreateOrderDTO orderDTO)
        {
            orderRepo.CreateOrder(orderDTO);
            return Ok("Order created successfully");
        }

        [HttpGet("Get Order By Id")]
      public IActionResult GetOrder(string id) 
        {
            var order = orderRepo.GetOrderById(id);
            return Ok(order);
        }

        [HttpDelete("Delete Order by Id")]

        public IActionResult Delete(string id)
        {
            orderRepo.DeleteOrderById(id);
            return Ok("Customer deleted successfully");
        }
    }
}
