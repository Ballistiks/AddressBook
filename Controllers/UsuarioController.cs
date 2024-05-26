using AddressBook.Models;
using AddressBook.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio usrRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            usrRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(UsuarioModel Usuario)
        {

            if (ModelState.IsValid)
            {
                usrRepositorio.NovoUsuario(Usuario);

                return RedirectToAction("Index");
            }
            return View(Usuario);

        }

    }
}
