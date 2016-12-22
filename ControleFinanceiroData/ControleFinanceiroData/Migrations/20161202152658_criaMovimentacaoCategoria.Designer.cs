using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ControleFinanceiroData;

namespace ControleFinanceiroData.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20161202152658_criaMovimentacaoCategoria")]
    partial class criaMovimentacaoCategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleFinanceiroData.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ControleFinanceiroData.Entidades.Movimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao");

                    b.Property<int>("Tipo");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ControleFinanceiroData.Entidades.Movimentacao", b =>
                {
                    b.HasOne("ControleFinanceiroData.Entidades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
        }
    }
}
