namespace Diplom_MVC.Models
{
    public class Theme
    {
        public Guid Id { get; set; }
        public string Titile { get; set; }
        public string Description {  get; set; }

        public Guid BoardId { get; set; }
        public Board? Board { get; set; }

        public List<Comment> Comments { get; set; } = new();
    }
}
