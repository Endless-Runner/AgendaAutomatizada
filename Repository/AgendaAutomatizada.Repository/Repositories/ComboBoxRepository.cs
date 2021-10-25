using AgendaAutomatizada.Domain.DTO;
using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaAutomatizada.Repository.Repositories
{
    public class ComboBoxRepository : IDisposable, IComboBoxRepository
    {
        private AgendaDbContext _AgendaContext;
        public ComboBoxRepository(AgendaDbContext context)
        {
            _AgendaContext = context;
        }


        public List<ComboBoxDTO> TandaComboBox() => _AgendaContext.Tandas
            .Where(t => t.Estado == true).Select(t => new ComboBoxDTO { Id = t.Id, Text = t.Descripcion }).ToList();

        public List<ComboBoxDTO> DiasComboBox() => _AgendaContext.Dias
            .Where(d => d.Estado == true).Select(t => new ComboBoxDTO { Id = t.Id, Text = t.Descripcion }).ToList();


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _AgendaContext = null;
            }

        }

        ~ComboBoxRepository()
        {
            Dispose(false);
        }
    }
}
