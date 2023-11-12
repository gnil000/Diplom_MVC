namespace Diplom_MVC.Models
{
    public class AnswerOnComment
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid CommentId { get; set; }
        public Comment? Comment { get; set; }
    }
}
