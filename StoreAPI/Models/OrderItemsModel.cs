using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models
{
    public class OrderItemsModel
    {
        
        public int Id { get; set; }

        public int OrderId { get; set; }
        
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductItemPrice { get; set; }
        public int ProductQuantity { get; set; }

        public double TotalPrice { get; set; }
        public string UserId { get; set; }

        
    }
}
