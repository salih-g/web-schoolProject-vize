using Microsoft.AspNetCore.Mvc;

namespace Party.Controllers
{
	public class GuestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
