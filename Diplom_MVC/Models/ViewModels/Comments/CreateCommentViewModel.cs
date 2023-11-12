namespace Diplom_MVC.Models.ViewModels.Comments
{
	public class CreateCommentViewModel
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public Guid ThemeId { get; set; }
	}
}
