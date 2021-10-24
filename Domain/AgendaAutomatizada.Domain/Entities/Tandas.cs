using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.Entities
{
    public class Tandas : GenericEntity
    {
        public string Descripcion { get; set; }

        public ICollection<Horario> Horarios { get; set; }
    }
}
