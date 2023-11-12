using Diplom_MVC.Models;
using Diplom_MVC.Models.Interfaces;
using Diplom_MVC.Models.ViewModels.Comments;
using Diplom_MVC.Models.ViewModels.Themes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Diplom_MVC.Controllers
{
	public class CommentController : Controller
	{
		private ICommentRepository _commentRepository;
		private readonly UserManager<User> _userManager;

		public CommentController(ICommentRepository _commentRepository, UserManager<User> userManager)
		{
			this._commentRepository = _commentRepository;
			_userManager = userManager;
		}

		public IActionResult Index(Theme theme)
		{
			var data = _commentRepository.GetAllByTheme(theme.Id);
			return View(data);
		}

		[Authorize(Roles = "user")]
		[HttpGet]
		public IActionResult Create(Theme theme)
		{
			ViewData["ThemeTitle"] = theme.Titile;
			ViewData["ThemeId"] = theme.Id;
			return View();
		}

		[Authorize(Roles = "user")]
		[HttpPost]
		public async Task<IActionResult> Create(CreateCommentViewModel model)
		{
			var a = User.Identity.Name;

			User b = await _userManager.FindByEmailAsync(a);

			Comment data = new Comment { ThemeId = model.ThemeId, UserId=Guid.Parse(b.Id), Title = model.Title, Description = model.Description, CreatedDate = DateTime.Now };
			_commentRepository.Create(data);
			return RedirectToAction("Index", "Comment", new Comment { Id = data.ThemeId });
		}
	}
}
