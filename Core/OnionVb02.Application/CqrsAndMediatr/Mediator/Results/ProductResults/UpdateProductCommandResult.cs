namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults
{
    public class UpdateProductCommandResult
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

