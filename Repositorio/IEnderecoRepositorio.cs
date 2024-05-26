using AddressBook.Models;

namespace AddressBook.Repositorio
{
	public interface IEnderecoRepositorio
	{
		EnderecoModel ListarID(int id);
		EnderecoModel NovoEndereco(EnderecoModel endereco);

		EnderecoModel AtualizarEndereco(EnderecoModel endereco);

		List<EnderecoModel> ShowAll();

		bool Delete(int id);


	}
}
