using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [NotMapped]
        public virtual CategoryModel Category { get; set; }

    }
}
