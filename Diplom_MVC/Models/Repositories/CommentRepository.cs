using Diplom_MVC.Models.Contexts;
using Diplom_MVC.Models.Interfaces;

namespace Diplom_MVC.Models.Repositories
{
	public class CommentRepository : ICommentRepository
	{
		private ApplicationContext _context;
		public CommentRepository(ApplicationContext _context)
		{
			this._context = _context;
		}

		public async Task Create(Comment comment)
		{
			await _context.Comments.AddAsync(comment);
			await _context.SaveChangesAsync();
		}

		public List<Comment> GetAllByTheme(Guid themeId)
		{
			return _context.Comments.Where(x=> x.ThemeId == themeId).ToList();
		}

		public Comment GetOne(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
