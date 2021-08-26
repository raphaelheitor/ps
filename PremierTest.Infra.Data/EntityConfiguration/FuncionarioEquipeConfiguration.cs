using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Infra.Data.EntityConfiguration
{
    public class FuncionarioEquipeConfiguration : IEntityTypeConfiguration<FuncionarioEquipe>
    {
        public void Configure(EntityTypeBuilder<FuncionarioEquipe> builder)
        {
            builder.HasKey(fe => new { fe.FuncionarioId, fe.EquipeId });

            builder.HasOne(fe => fe.Funcionario)
                .WithMany(f => f.FuncionarioEquipe)
                .HasForeignKey(fe => fe.FuncionarioId);


            builder.HasOne(fe => fe.Equipe)
                .WithMany(e => e.FuncionarioEquipe)
                .HasForeignKey(fe => fe.EquipeId);
        }
    }
}
