using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Controllers
{
	public class ContactController : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
