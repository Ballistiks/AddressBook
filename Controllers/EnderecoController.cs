using AddressBook.Models;
using AddressBook.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
	public class EnderecoController : Controller
	{
		private readonly IEnderecoRepositorio endRepositorio;
		public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
		{
			endRepositorio = enderecoRepositorio;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Novo()
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

		[HttpPost]
		public IActionResult Novo(EnderecoModel endereco)
		{
			endRepositorio.NovoEndereco(endereco);
			return RedirectToAction("Index");
		}


		/*public FileContentResult Exportar()
		{
			string csv = "\"Usuario_Id\",\"Logradoura\",\"Bairro\",\"Complemento\",\"Cidade\",\"UF\" \n";
			var enderecos = ""
			foreach (var lista in enderecos)
			{
				csv = csv + string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\" \n",
										   lista.Usuario_Id,
											lista.Logradouro,
										  lista.Bairro,
										   lista.Complemento,
										   lista.Cidade,
										   lista.UF);
			}
			//StringWriter sw = new StringWriter();
			//sw.WriteLine("\"ID\",\"Title\",\"Release Date\",\"Genere\",\"Price\",\"Rating\"");
			return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "Enderecos.csv");
		}*/



	}
}
