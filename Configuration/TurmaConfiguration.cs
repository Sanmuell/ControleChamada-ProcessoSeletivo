using System;

using controle_escolar.Models;
using controle_escolar.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace controle_escolar.Configuration
{
    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.Property(p => p.Turno).HasConversion(p => p.ToString(),
                p => (ETurno)Enum.Parse(typeof(ETurno), p));

        }
    }
}