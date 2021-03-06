using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.Entities
{
    public class Agenda : GenericEntity
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }

        public ICollection<Horario> Horarios { get; set; }
    }
}
