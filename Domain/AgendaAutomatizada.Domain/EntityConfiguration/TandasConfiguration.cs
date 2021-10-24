using AgendaAutomatizada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Domain.EntityConfiguration
{
    public class TandasConfiguration : IEntityTypeConfiguration<Tandas>
    {
        public void Configure(EntityTypeBuilder<Tandas> builder)
        {
            builder.ToTable("Tandas");
            builder.HasKey(t => t.Id);
        }
    }
}
