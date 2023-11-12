using Diplom_MVC.Models;
using Diplom_MVC.Models.Interfaces;
using Diplom_MVC.Models.ViewModels.Boards;
using Diplom_MVC.Models.ViewModels.Themes;
using Microsoft.AspNetCore.Mvc;

namespace Diplom_MVC.Controllers
{
	public class ThemeController : Controller
	{
		IThemeRepository _context;
		public ThemeController(IThemeRepository context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index(Board board)
		{
			var data = _context.GetAll(board.Id);
			return View(data);
		}

		[HttpGet]
		public IActionResult Create(Board board)
		{
			ViewData["BoardTitle"]= board.Title;
			ViewData["BoardId"] = board.Id;
			return View();
		}

		[HttpPost]
		public IActionResult Create(CreateThemeViewModel model) {
			Theme data = new Theme { BoardId=model.BoardId, Titile = model.Title, Description=model.Description};
			_context.Create(data);
			return RedirectToAction("Index", "Theme", new Board { Id=data.BoardId});
		}

	}
}
