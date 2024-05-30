using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreAPI.Data;
using StoreAPI.Models;
using System.Web;

namespace StoreAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {


        private readonly ApplicationDbContext _db;

        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }



        [HttpGet]
        public IList<CartGetDTO> CartItems()
        {


            //get current user

            var name = User.Identity.Name;
            var user = _db.Users.FirstOrDefault(x => x.UserName == name);




            var cartItems = _db.Carts.Where(x=>x.UserId==user.Id).ToList();

            List<CartGetDTO> cartGetDTOs = new List<CartGetDTO>();


            foreach (var cartItem in cartItems)
            {



                var x = new CartGetDTO
                {
                    UserId = user.Id,
                    ProductId = cartItem.ProductId,
                    ProductName = cartItem.ProductName,
                    ProductQuantity = cartItem.ProductQuantity,
                    ProductItemPrice = cartItem.ProductItemPrice,
                    TotalPrice = cartItem.TotalPrice

                };


                cartGetDTOs.Add(x);
            }




            return cartGetDTOs;
        }



        [HttpPost]
        public ActionResult<CartDTO> CartAdd(CartDTO cartDTO)


        {


            var user=_db.Users.FirstOrDefault(u=>u.UserName== User.Identity.Name);

                
                var product=_db.Products.FirstOrDefault(x=>x.Id==cartDTO.ProductId);
       
                


                var cartItem = new CartModel
                {
                    UserId = user.Id,
                    ProductId = cartDTO.ProductId,
                    ProductName = product.ProductName,
                    ProductItemPrice = product.Price,
                    ProductQuantity = cartDTO.ProductQuantity,
                    TotalPrice = cartDTO.ProductQuantity * product.Price,
                    
                   

                };

                _db.Carts.Add(cartItem);
                _db.SaveChanges();

            return Ok();



        }



        [HttpDelete]
        public ActionResult DeleteCartItem(int id)
        {


            var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            var cartItem= _db.Carts.FirstOrDefault(x=>x.Id==id);


            if (cartItem!=null)
            {
                _db.Carts.Remove(cartItem);
                _db.SaveChanges();
                return Ok();
            }
            return BadRequest();






        }


       



    }
}
