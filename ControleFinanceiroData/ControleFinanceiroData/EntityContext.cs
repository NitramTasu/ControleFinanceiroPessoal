using ControleFinanceiroData.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroData
{
    public class EntityContext:DbContext
    {

        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["controleDBConnectionString"].ConnectionString;

            optionsBuilder.UseSqlServer(stringConnection);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
