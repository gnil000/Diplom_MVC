using Diplom_MVC.Models.ViewModels.Themes;

namespace Diplom_MVC.Models.Interfaces
{
	public interface IThemeRepository
	{
		void Create(Theme theme);
		List<Theme> GetAll(Guid boardId);
		Theme GetOne(Guid id);
	}
}
