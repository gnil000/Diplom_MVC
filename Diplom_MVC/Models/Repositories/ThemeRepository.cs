using Diplom_MVC.Models.Contexts;
using Diplom_MVC.Models.Interfaces;

namespace Diplom_MVC.Models.Repositories
{
	public class ThemeRepository : IThemeRepository
	{
		private ApplicationContext _context;
		public ThemeRepository(ApplicationContext context)
		{
			_context = context;
		}
		public void Create(Theme theme)
		{
			_context.Theme.Add(theme);
			_context.SaveChanges();
		}

		public List<Theme> GetAll(Guid boardId)
		{
			return _context.Theme.Where(x=>x.BoardId == boardId).ToList();
		}

		public Theme GetOne(Guid id)
		{
			return _context.Theme.SingleOrDefault(x=> x.Id == id);
		}
	}
}
