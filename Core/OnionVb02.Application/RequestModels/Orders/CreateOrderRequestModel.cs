namespace OnionVb02.Application.RequestModels.Orders
{
    public class CreateOrderRequestModel
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}

