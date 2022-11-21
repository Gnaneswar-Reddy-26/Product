namespace Swiggy.Models
{
    public class Order_Details
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public int OrderId { get; set; }    
        public string OrderType { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
    }
}
