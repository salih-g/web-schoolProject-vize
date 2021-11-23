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


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(GuestResponse obj)
		{
			if (ModelState.IsValid)
			{
				_db.guestResponses.Add(obj);
				_db.SaveChanges();
				return View("Thanks", obj);
			}
			else
			{
				return View();
			}
		}

		[HttpGet]
		public IActionResult List()
		{
			IEnumerable<GuestResponse> objGuestList = _db.guestResponses;
			return View(objGuestList);
		}

		[HttpGet]
		public IActionResult Thanks()
		{
			return View();
		}

	}
}
