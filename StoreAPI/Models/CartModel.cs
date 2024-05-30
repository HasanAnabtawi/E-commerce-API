using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models
{
    public class CartModel
    {

        public int Id { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductItemPrice { get; set; }
        public int ProductQuantity { get; set; }

        public double TotalPrice { get; set; }
        public string UserId { get; set; }

        public ProductModel Products { get; set; }

        


    }
}
