using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinanceiroData.Entidades
{
    public class Movimentacao
    {

        public int Id{get; set;}
        public String Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int Tipo { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public override bool Equals(object obj)
        {
            Movimentacao movimentacao = (Movimentacao)obj;
            return this.Id == movimentacao.Id;
        }
    }
}