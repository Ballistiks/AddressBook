using AddressBook.Data;
using AddressBook.Models;
using Microsoft.Identity.Client;

namespace AddressBook.Repositorio
{
	private readonly DatabaseContext databaseContext;
	public class EnderecoRepositorio : IEnderecoRepositorio
	{
		public EnderecoRepositorio(DatabaseContext databaseContext)
		{
			databaseContext = DatabaseContext;
		}

		public EnderecoModel NovoEndereco(EnderecoModel endereco)
		{

		}
	}
}
