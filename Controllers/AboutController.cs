using FurnitureApp.Contexts;
using FurnitureApp.Models;
using FurnitureApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Controllers
{
	public class AboutController : Controller
	{

		readonly FurnitureDBContext _context;

		public AboutController(FurnitureDBContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			IEnumerable<Position> positions = await _context.Positions.Include(e=>e.Employees)
			  .AsNoTracking()
			  .ToListAsync();

			return View(positions);
		}

		public async Task<IActionResult> FakeData()
		{

			//List<Position> _positions = new List<Position>
			//{
			//	new Position
			//	{
			//		PositionName="Developer"
			//	},
			//	new Position
			//	{
			//		PositionName="Designer"
			//	}
			//};

			//List<Employee> _employees = new List<Employee>
			//{
			//	new Employee {
			//		Name ="Lawson Arnold",
			//		Description="Separated they live in. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.",
			//		Image="person_1.jpg",
			//		PositionId=5

			//	},

			//	new Employee {
			//		Name ="Jeremy Walker",
			//		Description="Separated they live in. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.",
			//		Image="person_2.jpg",
			//		PositionId=5



			//	},
			//	new Employee {
			//		Name ="Patrik White",
			//		Description="Separated they live in. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.",
			//		Image="person_3.jpg",
			//		PositionId=6



			//	},
			//	new Employee {
			//		Name ="Kathryn Ryan",
			//		Description="Separated they live in. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.",
			//		Image="person_4.jpg",
			//		PositionId=6
			//	},
			//};



			////_context.Positions.AddRange(_positions);
			//_context.Employees.AddRange(_employees);
			//_context.SaveChanges();
			//return Json("Ok");


			IQueryable<Employee> query = _context.Employees;
			List<Position> positions = await query.Select(q => new Position { PositionName = q.Position.PositionName }).ToListAsync();
			List<Employee> employees = await query.Select(q => new Employee { Description = q.Description, Name = q.Name, Image = q.Image, PositionId = q.PositionId }).ToListAsync();

			return Json(positions);
		}
	}
}
