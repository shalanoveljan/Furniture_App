using FurnitureApp.Contexts;
using FurnitureApp.Models;
using FurnitureApp.ViewModels;
using FurnitureApp.ViewModels.HomeVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FurnitureApp.Controllers
{
    public class HomeController : Controller
    {

        readonly FurnitureDBContext _context;

        public HomeController(FurnitureDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Services = await _context.Services.Select(x => new ServiceGetViewModel { Name = x.Name, Description = x.Description, Icon = x.Icon }).ToListAsync(),
                Testimonials = await _context.Testimonials
                .AsNoTracking()
                .Where(t => !t.IsDeleted)
                .Select(x => new TestimonialGetViewModel { Name = x.Name, Description = x.Description, Image = x.Image, PositionName = x.Position })
                .ToListAsync(),

                Setting = await _context.Settings.FirstOrDefaultAsync()
                
		};
            
			return View(homeVM);
        }


        public async Task<IActionResult> CreateSetting()
        {
            Setting setting = new Setting()
            {
                ServiceImage = "why-choose-us-img.jpg",
            };

            _context.Settings.Add(setting);


            List<Social> socials = new List<Social>
            {
                new Social { ScoialIcon="<span class='fa fa-brands fa-facebook-f'></span>",SocialUrl="https://www.facebook.com/",Setting=setting},
                new Social { ScoialIcon="<span class='fa fa-brands fa-instagram'></span>",SocialUrl="https://www.instagram.com/",Setting=setting}
            };
            setting.Socials = new List<Social>();
            setting.Socials.AddRange(socials);
            _context.SaveChanges();

            return Json("Ok");
        }

    }
}