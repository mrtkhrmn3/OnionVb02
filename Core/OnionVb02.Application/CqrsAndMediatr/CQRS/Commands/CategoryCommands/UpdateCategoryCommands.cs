namespace OnionVb02.Application.CqrsAndMediatr.CQRS.Commands.CategoryCommands
{
    public class UpdateCategoryCommands
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
