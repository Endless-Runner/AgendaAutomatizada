using AgendaAutomatizada.Domain.Entities;
using AgendaAutomatizada.Domain.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.SQL
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UsuarioConfiguration());
            builder.ApplyConfiguration(new AgendaConfiguration());
            builder.ApplyConfiguration(new TandasConfiguration());
            builder.ApplyConfiguration(new HorarioConfiguration());
            builder.ApplyConfiguration(new DiaConfiguration());
            //builder.ApplyConfiguration(new NombreDeLaConfiguracion());

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Tandas> Tandas { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Dia> Dias { get; set; }
        //public DbSet<NombreDeLaClase> NombreUtilizadoEnElCodigo { get; set; }
    }
}
