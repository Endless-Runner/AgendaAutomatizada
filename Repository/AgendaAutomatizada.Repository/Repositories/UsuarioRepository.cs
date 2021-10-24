using AgendaAutomatizada.Domain.Entities;
using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaAutomatizada.Repository.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AgendaDbContext context) : base(context) { }
        public AgendaDbContext AgendaContext { get { return context; } }

       public void addUsuario(Usuario usuario)
        {
            usuario.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
            usuario.Estado = true;
            Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            var usuarioToUpdate = Get(usuario.Id);
            usuarioToUpdate.Nombre = usuario.Nombre;
            usuarioToUpdate.Apellido = usuario.Apellido;
            usuarioToUpdate.Apodo = usuario.Apodo;
            usuarioToUpdate.Estado = usuario.Estado;
            usuarioToUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }

        public bool Login(string usuario, string clave) => context.Usuarios
                .Any(u=>(u.Apodo.ToLower().Equals(usuario.ToLower())
                || u.Correo.ToLower().Equals(usuario.ToLower()))
                && u.Password.ToLower().Equals(clave.ToLower()));


    }
}
