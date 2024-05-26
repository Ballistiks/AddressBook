using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
	public class SignController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
