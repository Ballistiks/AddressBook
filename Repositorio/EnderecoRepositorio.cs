using AddressBook.Data;
using AddressBook.Migrations;
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

		public EnderecoModel ListarID(int id)
		{
			var endereco = dbContext.Enderecos.FirstOrDefault(x => x.Id == id);
			return endereco ?? new EnderecoModel();
		}

		public EnderecoModel NovoEndereco(EnderecoModel endereco)
		{
			dbContext.Enderecos.Add(endereco);
			dbContext.SaveChanges();
			return endereco;
		}

		public List<EnderecoModel> ShowAll()
		{
			return [.. dbContext.Enderecos];
		}
	}
}
