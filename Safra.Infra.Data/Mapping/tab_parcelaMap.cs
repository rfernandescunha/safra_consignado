using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Safra.Domain.Entities;

namespace Safra.Infra.Data.Mapping
{
    class tab_parcelaMap : IEntityTypeConfiguration<tab_parcela>
    {
        public void Configure(EntityTypeBuilder<tab_parcela> entity)
        {
            entity.ToTable("tab_parcela");

            entity.HasKey(e => e.idParcela);

            entity.Property(e => e.idParcela).ValueGeneratedNever();

            entity.Property(e => e.dt_pgto_parcela).HasColumnType("datetime");

            entity.Property(e => e.dt_venc_parcela).HasColumnType("datetime");

            entity.Property(e => e.vl_parcela).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.idFinanciamentoNavigation)
                .WithMany(p => p.tab_parcela)
                .HasForeignKey(d => d.idFinanciamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tab_parcela_tab_financiamento");

        }
    }
}
