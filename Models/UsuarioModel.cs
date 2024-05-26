using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Konscious.Security.Cryptography;

namespace AddressBook.Models
{
	public class UsuarioModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(50)]
		public string? Nome { get; set; }

		[MaxLength(255)]
		public string? Login { get; set; }

		[MaxLength(255)]
		public string? Senha { get; set; }

		public bool SenhaValida(string senha)
		{
			return Senha == senha;
		}
	}
}
