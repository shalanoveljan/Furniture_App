namespace FurnitureApp.Models
{
	public class Social
	{
		public int Id { get; set; }

		public string SocialUrl { get; set; }

		public string ScoialIcon { get; set; }

		public int SettingID { get; set; }

		public Setting Setting { get; set; }
	}
}
