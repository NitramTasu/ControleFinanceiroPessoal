using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinanceiroData.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IList<Movimentacao> Movimentacoes { get; set; }
    }
}