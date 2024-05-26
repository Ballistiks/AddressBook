using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
	public class EnderecoModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(80)]
		public string? Logradouro { get; set; }

		[MaxLength(80)]
		public string? Complemento { get; set; }

		[MaxLength(80)]
		public string? Bairro { get; set; }

		[MaxLength(80)]
		public string? Cidade { get; set; }

		[MaxLength(3)]
		public string? UF { get; set; }

		[MaxLength(10)]
		public string? Cep { get; set; }

	}
}
