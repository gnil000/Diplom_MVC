using Diplom_MVC.Models;
using Diplom_MVC.Models.Interfaces;
using Diplom_MVC.Models.Repositories;
using Diplom_MVC.Models.ViewModels.Boards;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Diplom_MVC.Controllers
{
    public class BoardController : Controller
    {
        IBoardRepository _context;
		private readonly UserManager<User> _userManager;
		public BoardController(IBoardRepository context)
        {
            _context = context;
        }

		[Authorize(Roles = "user")]
		public IActionResult IndexForUser()
		{
			var data = _context.GetAll();
			return View(data);
		}

		[Authorize(Roles = "admin")]
		public IActionResult Index()
        {
			//var a = User.Identity.Name;
			//User b = await _userManager.FindByEmailAsync(a);
   //         var c = await _userManager.GetRolesAsync(b);
   //         if (c.Contains("user"))
   //             return RedirectToAction("IndexForUser", "Board");

            var data = _context.GetAll();
            return View(data);
        }

		[Authorize(Roles = "admin")]
		[HttpGet]
        public IActionResult Create() { 
            return View();
        }

		[Authorize(Roles = "admin")]
		[HttpPost]
        public async Task<IActionResult> Create(CreateBoardViewModel model) {

            if (ModelState.IsValid)
            {
                Board board = new() { Title = model.Title, Description = model.Description };
                await _context.Create(board);
                return RedirectToAction("Index", "Board");
            }
            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult GetOne(Guid id) {
            var data = _context.GetOne(id);
            if(data == null)
                return NotFound();
            return View(data);
        }

    }
}
