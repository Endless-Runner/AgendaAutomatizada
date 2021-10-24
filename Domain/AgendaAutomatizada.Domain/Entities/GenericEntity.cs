using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.Entities
{
    public class GenericEntity
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; }
    }
}
