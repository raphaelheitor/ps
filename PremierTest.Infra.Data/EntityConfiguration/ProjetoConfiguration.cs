using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PremierTest.Domain.Entities;

namespace PremierTest.Infra.Data.EntityConfiguration
{
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.HasOne(p => p.Equipe)
                .WithMany(e => e.Projetos)
                .HasForeignKey(p => p.EquipeId);
        }
    }
}
