using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AgendaAutomatizada.Domain.Entities
{
    public class Usuario : GenericEntity
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        public string Password { get; set; }
        public string Apodo { get; set; }
        [Required]
        public string Correo { get; set; }
    }
}
