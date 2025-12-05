namespace OnionVb02.Application.CqrsAndMediatr.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommands
    {
        public int Id { get; set; }

        public RemoveCategoryCommands(int ıd)
        {
            Id = ıd;
        }
    }
}
