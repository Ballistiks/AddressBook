using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
	public class UsuarioModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string? Nome { get; set; }

		[Required]
		[MaxLength(255)]
		public string? Login { get; set; }

		[Required]
		[MaxLength(255)]
		public string? Senha { get; set; }

		public bool SenhaValida(string senha)
		{
			return Senha == senha;
		}


	}
}
