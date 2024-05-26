using AddressBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Data
{
	public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
	{
		public DbSet<EnderecoModel> Enderecos { get; set; }
	}
}
