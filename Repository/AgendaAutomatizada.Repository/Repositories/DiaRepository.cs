using AgendaAutomatizada.Domain.Entities;
using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Repository.Repositories
{
    public class DiaRepository : BaseRepository<Dia>, IDiaRepository
    {
        public DiaRepository(AgendaDbContext context) : base(context) { }
        public AgendaDbContext AgendaContext { get { return context; } }

        public void addDia(Dia dia)
        {
            dia.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
            dia.Estado = true;
            Add(dia);
        }

        public void Update(Dia dia)
        {
            var diaToUpdate = Get(dia.Id);
            diaToUpdate.Descripcion = dia.Descripcion;
            diaToUpdate.Estado = dia.Estado;
            diaToUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
