using System.ComponentModel.DataAnnotations;

namespace FurnitureApp.ViewModels
{
	public class TestimonialGetViewModel
	{
		[StringLength(60)]

		public string Image { get; set; }
		[StringLength(40)]

		public string Name { get; set; }
		[StringLength(1000)]


		public string Description { get; set; }

		[StringLength(70)]
		public string PositionName { get; set; }
	}
}
