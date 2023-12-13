using System.ComponentModel.DataAnnotations;

namespace FurnitureApp.Models
{
	public class Employee
	{
		public int Id { get; set; }
		[StringLength(60)]
		public string Name { get; set; }
		[StringLength(400)]
		public string Description { get; set; }
		[StringLength(60)]
		public string Image { get; set; }

		public int PositionId { get; set; }
		public Position Position { get; set; }

		public bool IsDeleted { get; set; }	
	}
}
