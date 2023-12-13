using FurnitureApp.Models;

namespace FurnitureApp.ViewModels.HomeVMs
{
	public class HomeVM
	{
		public IEnumerable<ServiceGetViewModel> Services { get; set; }
		public IEnumerable<TestimonialGetViewModel> Testimonials { get; set; }

		public Setting Setting { get; set; }

		public HomeVM()
		{
			Services= new HashSet<ServiceGetViewModel>();
			Testimonials= new HashSet<TestimonialGetViewModel>();
			Setting=new Setting();
		}

	}
}
