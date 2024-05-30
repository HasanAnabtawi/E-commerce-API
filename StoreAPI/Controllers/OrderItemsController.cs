using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {

        private readonly ApplicationDbContext _db;
        public OrderItemsController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public List<OrderItemsModel> GetOrderItems()
        {
            var orderItems = _db.OrderItems.ToList();


            return orderItems;


        }
    }
}
