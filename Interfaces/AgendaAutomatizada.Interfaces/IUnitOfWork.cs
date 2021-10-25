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
        ITandaRepository Tandas { get; }
        IAgendaRepository Agendas { get; }
        IHorarioRepository Horarios { get; }
        IDiaRepository Dias { get; }
        IComboBoxRepository ComboBox { get; }
        //INombreDeLaInterfaz ComoSeraLlamadaEnLaAplicaicon { get; }

        void Dispose();
    }
}
