using AddressBook.Data;
using AddressBook.Models;

namespace AddressBook.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly DatabaseContext dbContext;

        public UsuarioRepositorio(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public UsuarioModel NovoUsuario(UsuarioModel Usuario)
        {
            dbContext.Usuarios.Add(Usuario);
            dbContext.SaveChanges();
            return Usuario;
        }
    }
}
