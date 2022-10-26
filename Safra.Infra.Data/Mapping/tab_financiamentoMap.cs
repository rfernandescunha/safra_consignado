using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Safra.Domain.Entities;

namespace Safra.Infra.Data.Mapping
{
    class tab_financiamentoMap : IEntityTypeConfiguration<tab_financiamento>
    {
        public void Configure(EntityTypeBuilder<tab_financiamento> entity)
        {
            entity.ToTable("tab_financiamento");

            entity.HasKey(e => e.idFinanciamento);

            entity.Property(e => e.idFinanciamento).ValueGeneratedNever();

            entity.Property(e => e.dt_ultimo_vencimento).HasColumnType("datetime");

            entity.Property(e => e.vl_total).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.idClienteNavigation)
                .WithMany(p => p.tab_financiamento)
                .HasForeignKey(d => d.idCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tab_financiamento_tab_cliente");

            entity.HasOne(d => d.idTipoCreditoNavigation)
                .WithMany(p => p.tab_financiamento)
                .HasForeignKey(d => d.idTipoCredito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tab_financiamento_tab_tipo_credito");

        }
    }
}