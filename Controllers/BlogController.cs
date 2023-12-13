using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Controllers
{
	public class BlogController : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
