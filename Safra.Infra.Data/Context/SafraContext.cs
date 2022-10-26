
using Microsoft.EntityFrameworkCore;
using Safra.Domain.Entities;
using Safra.Infra.Data.Mapping;


namespace Safra.Infra.Data
{
    public partial class SafraContext : DbContext
    {

        public SafraContext(DbContextOptions<SafraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tab_cliente> tab_cliente { get; set; }
        public virtual DbSet<tab_financiamento> tab_financiamento { get; set; }
        public virtual DbSet<tab_parcela> tab_parcela { get; set; }
        public virtual DbSet<tab_tipo_credito> tab_tipo_credito { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<tab_cliente>(entity =>
            {
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
            });

            modelBuilder.Entity<tab_financiamento>(entity =>
            {
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
            });

            modelBuilder.Entity<tab_parcela>(entity =>
            {
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
            });

            modelBuilder.Entity<tab_tipo_credito>(entity =>
            {
                entity.HasKey(e => e.idTipoCredito);

                entity.Property(e => e.tp_credito)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.vl_max_pf).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.vl_max_pj).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.vl_min_pf).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.vl_min_pj).HasColumnType("decimal(8, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<tab_cliente>(new tab_clienteMap().Configure);

        //    modelBuilder.Entity<tab_financiamento>(new tab_financiamentoMap().Configure);

        //    modelBuilder.Entity<tab_parcela>(new tab_parcelaMap().Configure);

        //    modelBuilder.Entity<tab_tipo_credito>(new tab_tipo_creditoMap().Configure);

        //    //OnModelCreatingPartial(modelBuilder);
        //}

        ////partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}