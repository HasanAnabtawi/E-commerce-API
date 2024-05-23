using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models
{
    public class ProductModelDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        
        public int CategoryId { get; set; }
        

    }
}
