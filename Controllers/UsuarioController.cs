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
		[ValidateAntiForgeryToken]
		public IActionResult Novo(UsuarioModel usuario)
		{

			if (ModelState.IsValid)
			{
				usuario.Senha = "";
				usrRepositorio.NovoUsuario(usuario);

				return RedirectToAction("Index");
			}
			return View(usuario);

		}

	}
}
