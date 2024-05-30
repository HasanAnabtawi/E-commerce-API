using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        private readonly ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db) {
        
        _db= db;

        
        }



        [HttpGet]
        public List<OrderModel> GetOrder()
        {
           var orders= _db.Orders.Include(order=>order.OrderItems).ToList();


            return orders;


        }


        







        [HttpPost("CartCheckout")]
        public ActionResult<OrderModel> CartCheckout()
        {




            var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);



            var cartItems = _db.Carts.Where(x => x.UserId == user.Id).ToList();

            var totalAmount=cartItems.Select(x=>x.TotalPrice).Sum();


            var order = new OrderModel
            {
                UserId = user.Id,
                OrderTime = DateTime.Now,
                OrderTotalAmount = totalAmount
                
                
              


            };
            foreach (var cartItem in cartItems)
            {
                var item = new OrderItemsModel
                {
                    OrderId = order.Id,
                    ProductId = cartItem.ProductId,
                    ProductName = cartItem.ProductName,
                    ProductItemPrice = cartItem.ProductItemPrice,
                    ProductQuantity = cartItem.ProductQuantity,
                    TotalPrice = cartItem.TotalPrice,
                    UserId = user.Id,


                };


                order.OrderItems.Add(item);

            }
            _db.Orders.Add(order);


            foreach (var cartItem in cartItems)
            {
                _db.Carts.Remove(cartItem);
            }
            
            _db.SaveChanges();


            return Ok();

        }








    }
}
