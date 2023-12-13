using FurnitureApp.Contexts;
using FurnitureApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Services
{
	public class SettingService
	{
		readonly FurnitureDBContext _context;

		public SettingService(FurnitureDBContext context)
		{
			_context = context;
		}

		public async Task<Setting> GetSettings()
		{
			return await _context.Settings.Include(x => x.Socials).FirstOrDefaultAsync();

			//
		}
	}
}
