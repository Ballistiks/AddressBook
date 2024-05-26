using AddressBook.Data;
using AddressBook.Models;
using Microsoft.Identity.Client;

namespace AddressBook.Repositorio
{

	public class EnderecoRepositorio : IEnderecoRepositorio
	{
		private readonly DatabaseContext dbContext;

		public EnderecoRepositorio(DatabaseContext databaseContext)
		{
			dbContext = databaseContext;
		}

		public EnderecoModel NovoEndereco(EnderecoModel endereco)
		{
			dbContext.Enderecos.Add(endereco);
			dbContext.SaveChanges();
			return endereco;
		}
	}
}
