namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults
{
    public class CreateOrderDetailCommandResult
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}

