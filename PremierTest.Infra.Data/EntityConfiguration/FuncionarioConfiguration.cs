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

            //builder.HasData(new Funcionario { 
            //    Nome = "Colaborador 1",
            //    Matricula = "12345",
            //    Password = "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", //senha
            //    Perfil = "colaborador"
            //}, new Funcionario {
            //    Nome = "Colaborador 2",
            //    Matricula = "54321",
            //    Password = "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", //senha
            //    Perfil = "colaborador"
            //}, new Funcionario
            //{
            //    Nome = "Gestor",
            //    Matricula = "111",
            //    Password = "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", //senha
            //    Perfil = "gestor"
            //});
        }
    }
}
