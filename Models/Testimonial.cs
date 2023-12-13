using System.ComponentModel.DataAnnotations;

namespace FurnitureApp.Models
{
	public class Testimonial
	{
		public int Id { get; set; }

		[StringLength(30)]
		public string Image { get; set; }
		[StringLength(40)]

		public string Name { get; set; }
		[StringLength(1000)]


		public string Description { get; set; }

		[StringLength(30)]
		public string Position { get; set; }	

		public bool IsDeleted { get; set; }


	}
}
