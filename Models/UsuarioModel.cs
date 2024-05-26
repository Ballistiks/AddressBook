using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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

		[MaxLength(80)]
		public string? Senha { get; set; }
	}
}
