namespace Diplom_MVC.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        //public Guid BoardId { get; set; }
        //public Board? Board { get; set; }

        public Guid ThemeId { get; set; }
        public Theme? Theme { get; set; }
    }
}
