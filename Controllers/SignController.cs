using AddressBook.Models;
using AddressBook.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
	public class SignController : Controller
	{
		private readonly IUsuarioRepositorio usrRepositorio;
		public SignController(IUsuarioRepositorio usuarioRepositorio)
		{
			usrRepositorio = usuarioRepositorio;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Novo(UsuarioModel usuario)
		{
			try
			{
				if (ModelState.IsValid)
				{
					usuario = usrRepositorio.NovoUsuario(usuario);
					return RedirectToAction("Index");
				}
				return View(usuario);
			}
			catch (Exception ex)
			{
				throw new Exception("Erro: " + ex.Message);
			}
		}
	}
}