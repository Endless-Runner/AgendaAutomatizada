using AgendaAutomatizada.Domain.Entities;
using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Repository.Repositories
{
    public class HorarioRepository : BaseRepository<Horario>, IHorarioRepository
    {
        public HorarioRepository(AgendaDbContext context) : base(context) { }
        public AgendaDbContext AgendaContext { get { return context; } }

        public void AddHorario(Horario horario)
        {
            horario.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
            horario.Estado = true;
            Add(horario);
        }

        public void Update(Horario horario)
        {
            var horarioToUpdate = Get(horario.Id);
            horarioToUpdate.Nombre = horario.Nombre;
            horarioToUpdate.Estado = horario.Estado;
            horarioToUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
