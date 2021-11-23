using Party.Data;
using Party.Models;
using Microsoft.AspNetCore.Mvc;

namespace Party.Controllers
{
	public class GuestController : Controller
	{

		private readonly ApplicationDbContext _db;

		public GuestController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult List()
		{
			IEnumerable<GuestResponse> objGuestList = _db.guestResponses;
			return View(objGuestList);
		}

		public IActionResult Thanks()
		{
			return View();
		}

	}
}
