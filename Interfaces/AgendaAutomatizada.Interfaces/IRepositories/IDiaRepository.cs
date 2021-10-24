using AgendaAutomatizada.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces.IRepositories
{
    public interface IDiaRepository : IBaseRepository<Dia>
    {
        void addDia(Dia dia);
        void Update(Dia dia);
    }
}
