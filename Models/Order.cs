namespace HHPW.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public long PhoneNum { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string PaymentType { get; set; }
        public int Total {  get; set; }
        public int Tip { get; set; }
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }
}