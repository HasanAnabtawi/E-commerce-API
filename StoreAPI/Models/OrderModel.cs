namespace StoreAPI.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime OrderTime { get; set; }
        public double OrderTotalAmount { get; set; }
        public IList<OrderItemsModel> OrderItems{get; set;} = new List<OrderItemsModel>();
       
    }
}
