using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Safra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Infra.Data.Mapping
{
    public class tab_tipo_creditoMap : IEntityTypeConfiguration<tab_tipo_credito>
    {
        public void Configure(EntityTypeBuilder<tab_tipo_credito> entity)
        {
            entity.ToTable("tab_tipo_credito");

            entity.HasKey(e => e.idTipoCredito);

            entity.Property(e => e.tp_credito)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.vl_max_pf).HasColumnType("decimal(8, 2)");

            entity.Property(e => e.vl_max_pj).HasColumnType("decimal(8, 2)");

            entity.Property(e => e.vl_min_pf).HasColumnType("decimal(8, 2)");

            entity.Property(e => e.vl_min_pj).HasColumnType("decimal(8, 2)");

        }
    }
}