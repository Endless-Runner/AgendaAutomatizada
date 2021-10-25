using AgendaAutomatizada.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces.IRepositories
{
    public interface IAgendaRepository : IBaseRepository<Agenda>
    {
        void addAgenda(Agenda agenda);
        void Update(Agenda agenda);
        dynamic ListAgendaById(int id);
    }
}
