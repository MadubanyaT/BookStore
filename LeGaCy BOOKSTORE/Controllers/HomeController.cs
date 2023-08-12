using Microsoft.AspNetCore.Mvc;

namespace LeGaCy_BOOKSTORE.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
