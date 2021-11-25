using Party.Data;
using Party.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

			var result = from guest in _db.guestResponses
						 where guest.WillAttend == true
						 select new GuestResponse
						 {
							 Id = guest.Id,
							 Email = guest.Email,
							 Name = guest.Name,
							 Phone = guest.Phone,
							 WillAttend = guest.WillAttend
						 };

			IEnumerable<GuestResponse> objGuestList = result.ToList();



			return View(objGuestList);
		}

		[HttpGet]
		public IActionResult Thanks()
		{
			return View();
		}

	}
}
