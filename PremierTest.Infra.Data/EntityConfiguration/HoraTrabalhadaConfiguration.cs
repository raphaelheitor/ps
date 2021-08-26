using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Infra.Data.EntityConfiguration
{
    public class HoraTrabalhadaConfiguration : IEntityTypeConfiguration<HoraTrabalhada>
    {
        public void Configure(EntityTypeBuilder<HoraTrabalhada> builder)
        {
            builder.HasKey(ht => ht.Id);

            builder.Property(ht => ht.Horas)
                .IsRequired(true)
                .HasColumnType("decimal(5,2)");

            builder.HasOne(ht => ht.Projeto)
                .WithMany(p => p.HorasTrabalhadas)
                .HasForeignKey(ht => ht.ProjetoId)
                .IsRequired(true);

            builder.HasOne(ht => ht.Colaborador)
                .WithMany(f => f.HorasTrabalhadas)
                .HasForeignKey(ht => ht.FuncionarioId)
                .IsRequired(true);
        }
    }
}
