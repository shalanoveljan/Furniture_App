using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Controllers
{
	public class ShopController : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
