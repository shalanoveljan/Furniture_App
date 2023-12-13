using System.ComponentModel.DataAnnotations;

namespace FurnitureApp.ViewModels
{
	public class ServiceGetViewModel
	{
		public string Icon { get; set; }
		[StringLength(50)]
		public string Name { get; set; }
		[StringLength(300)]

		public string Description { get; set; }
	}
}
