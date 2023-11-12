namespace Diplom_MVC.Models.Interfaces
{
	public interface ICommentRepository
	{
		Task Create(Comment comment);
		List<Comment> GetAllByTheme(Guid themeId);
		Comment GetOne(Guid id);
	}
}
