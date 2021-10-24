using AgendaAutomatizada.Domain.Entities;
using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Repository.Repositories
{
    public class TandaRepository : BaseRepository<Tandas>, ITandaRepository
    {
        public TandaRepository(AgendaDbContext context) : base(context) { }
        public AgendaDbContext AgendaContext { get { return context; } }

        public void addTanda(Tandas tandas)
        {
            tandas.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
            tandas.Estado = true;
            Add(tandas);
        }

        public void Update(Tandas tandas)
        {
            var tandasToUpdate = Get(tandas.Id);
            tandasToUpdate.Descripcion = tandas.Descripcion;
            tandasToUpdate.Estado = tandas.Estado;
            tandasToUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
