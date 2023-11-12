namespace Diplom_MVC.Models
{
    public class Board
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Theme> Themes { get; set; } = new();
    }
}
