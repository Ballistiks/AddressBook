using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class EnderecoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo ()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }



    }
}
