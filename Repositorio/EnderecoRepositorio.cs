using AddressBook.Data;
using AddressBook.Models;

namespace AddressBook.Repositorio
{

	public class EnderecoRepositorio : IEnderecoRepositorio
	{
		private readonly DatabaseContext dbContext;

		public EnderecoRepositorio(DatabaseContext databaseContext)
		{
			dbContext = databaseContext;
		}

		public EnderecoModel AtualizarEndereco(EnderecoModel endereco)
		{
			EnderecoModel enderecoDB = ListarID(endereco.Id) ?? throw new Exception("Problema Detectado!");
			enderecoDB.Cep = endereco.Cep;
			enderecoDB.Logradouro = endereco.Logradouro;
			enderecoDB.Bairro = endereco.Bairro;
			enderecoDB.Complemento = endereco.Complemento;
			enderecoDB.Cidade = endereco.Cidade;
			enderecoDB.UF = endereco.UF;
			dbContext.Enderecos.Update(enderecoDB);
			dbContext.SaveChanges();
			return enderecoDB;
		}

		public bool Delete(int id)
		{
			EnderecoModel enderecoDB = ListarID(id) ?? throw new Exception("Problema Detectado!");
			dbContext.Enderecos.Remove(enderecoDB);
			dbContext.SaveChanges();
			return true;
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
