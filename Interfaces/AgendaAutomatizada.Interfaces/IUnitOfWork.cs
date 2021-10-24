using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces
{
    public interface IUnitOfWork
    {
        int Complete();


        IUsuarioRepository Usuarios { get; }
        //INombreDeLaInterfaz ComoSeraLlamadaEnLaAplicaicon { get; }

        void Dispose();
    }
}
