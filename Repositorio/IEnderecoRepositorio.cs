using AddressBook.Models;

namespace AddressBook.Repositorio
{
	public interface IEnderecoRepositorio
	{
		EnderecoModel NovoEndereco(EnderecoModel endereco);
		List<EnderecoModel> ShowAll();

	}
}
