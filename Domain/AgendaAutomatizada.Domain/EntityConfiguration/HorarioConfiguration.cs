using AgendaAutomatizada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.EntityConfiguration
{
    public class HorarioConfiguration : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> builder)
        {
            builder.ToTable("Horarios");
            builder.HasKey(h => h.Id);

            builder.HasOne(h => h.Tandas)
                .WithMany(t => t.Horarios)
                .HasForeignKey(h => h.IdTanda)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(h => h.Agenda)
                .WithMany(t => t.Horarios)
                .HasForeignKey(h => h.IdAgenda)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(h => h.Dia)
                .WithMany(t => t.Horarios)
                .HasForeignKey(h => h.idDia)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
