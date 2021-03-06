using AgendaAutomatizada.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces.IRepositories
{
    public interface ITandaRepository : IBaseRepository<Tandas>
    {
        void addTanda(Tandas tandas);
        void Update(Tandas tandas);
    }
}
