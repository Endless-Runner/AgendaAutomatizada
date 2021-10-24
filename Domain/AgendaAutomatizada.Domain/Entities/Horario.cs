using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.Entities
{
    public class Horario : GenericEntity
    {
        public int IdTanda { get; set; }
        public int IdAgenda { get; set; }
        public string Nombre { get; set; }

        public Tandas Tandas { get; set; }
        public Agenda Agenda { get; set; }

    }
}
