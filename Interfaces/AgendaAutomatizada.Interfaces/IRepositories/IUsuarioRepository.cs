using AgendaAutomatizada.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces.IRepositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        void addUsuario(Usuario usuario);
        void Update(Usuario usuario);
        bool Login(string usuario, string clave);
        int GetId(string usuario);
    }
}
