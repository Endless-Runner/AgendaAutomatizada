using AgendaAutomatizada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.EntityConfiguration
{
    public class DiaConfiguration : IEntityTypeConfiguration<Dia>
    {
        public void Configure(EntityTypeBuilder<Dia> builder)
        {
            builder.ToTable("Dias");
            builder.HasKey(d => d.Id);
        }
    }
}
