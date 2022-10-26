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
    public class tab_clienteMap : IEntityTypeConfiguration<tab_cliente>
    {
        public void Configure(EntityTypeBuilder<tab_cliente> entity)
        {
            entity.ToTable("tab_cliente");

                entity.HasKey(e => e.idCliente);

                entity.Property(e => e.celular)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.cpf_cnpj)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.dt_cadastro).HasColumnType("datetime");

                entity.Property(e => e.nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.tp_pessoa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            
        }
    }
}
