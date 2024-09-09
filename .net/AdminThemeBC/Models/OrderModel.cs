namespace AdminThemeBC.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMode { get; set; }
        public double? TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderName { get; set; }
        public int UserID { get; set; }
    }

}
