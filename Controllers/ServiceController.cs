using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Controllers
{
	public class ServiceController : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
