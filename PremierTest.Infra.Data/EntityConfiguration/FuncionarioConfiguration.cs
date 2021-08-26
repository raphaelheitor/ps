using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PremierTest.Domain.Entities;

namespace PremierTest.Infra.Data.EntityConfiguration
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");

            builder.Property(f => f.Matricula)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar(20)");

            builder.Property(f => f.Password)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");

            builder.Property(f => f.Perfil)
                .IsRequired();
        }
    }
}
