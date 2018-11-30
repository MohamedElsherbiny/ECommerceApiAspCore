using ApiDesign.Data;
using ApiDesign.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesign.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _repo;
        public OrderController(IOrderRepository repo)
        {
            _repo = repo;

        }
        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            return Ok(_repo.GetOrders());
        }
        [HttpPost("addOrder")]
        public IActionResult AddOrders([FromBody]Order order)
        {
            if (order != null)
            {
                _repo.AddOrder(order);

                return Ok();
            }
            return Unauthorized();
        }
    }
}