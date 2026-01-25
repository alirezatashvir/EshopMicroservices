namespace Discount.Grpc.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = default!;
        public string Desciption { get; set; } = default!;
        public int Amount { get; set; }
    }
}
