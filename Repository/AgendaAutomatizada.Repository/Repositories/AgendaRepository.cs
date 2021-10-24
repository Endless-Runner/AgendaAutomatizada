﻿using AgendaAutomatizada.Domain.Entities;
using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Repository.Repositories
{
    public class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        public AgendaRepository(AgendaDbContext context) : base(context) { }
        public AgendaDbContext AgendaContext { get { return context; } }

        public void addAgenda(Agenda agenda)
        {
            agenda.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
            agenda.Estado = true;
            Add(agenda);
        }

        public void Update(Agenda agenda)
        {
            var agendaToUpdate = Get(agenda.Id);
            agendaToUpdate.Estado = agenda.Estado;
            agendaToUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
