using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces
{
    public interface IUnitOfWork
    {
        int Complete();
        //INombreDeLaInterfaz ComoSeraLlamadaEnLaAplicaicon { get; }

        void Dispose();
    }
}
