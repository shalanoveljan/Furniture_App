namespace FurnitureApp.Models
{
	public class Position
	{
		public int Id { get; set; }
		public string PositionName { get; set; }
		public List<Employee> Employees { get; set; }

		
	}
}
