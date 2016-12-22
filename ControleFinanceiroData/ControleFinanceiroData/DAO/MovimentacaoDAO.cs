using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControleFinanceiroData.Entidades;

namespace ControleFinanceiroData.DAO
{
    public class MovimentacaoDao
    {

        EntityContext contexto;
        public MovimentacaoDao()
        {
            this.contexto = new EntityContext();
        }
        public void Adicionar(Movimentacao movimentacao)
        {
            contexto.Movimentacoes.Add(movimentacao);

            contexto.SaveChanges();
        }

        public void Remover(Movimentacao movimentacao)
        {
            contexto.Movimentacoes.Remove(movimentacao);
            contexto.SaveChanges();
        }

        public Movimentacao BuscarPorId(int id)
        {
            return contexto.Movimentacoes.FirstOrDefault(m=> m.Id == id);
        }

        public IList<Movimentacao> Lista()
        {
            return contexto.Movimentacoes.ToList();
        }

        public decimal getValorTotal()
        {
            return contexto.Movimentacoes.Sum(m=> m.Valor);
        }

        public decimal getReceitaTotal()
        {
            return contexto.Movimentacoes.Where(m=> m.Tipo == 1).Sum(m => m.Valor );
        }

        public decimal getDespesaTotal()
        {
            return contexto.Movimentacoes.Where(m => m.Tipo == 2).Sum(m => m.Valor);
        }

        public decimal getTotalSaidaDoMes()
        {
            DateTime currentDate = DateTime.Now;
            return contexto.Movimentacoes.Where(m=>m.Tipo == 2 && m.Data.Month == currentDate.Month).Sum(m=>m.Valor);
        }

        public decimal getTotalEntradaMes()
        {
            DateTime currentDate = DateTime.Now;
            return contexto.Movimentacoes.Where(m => m.Tipo == 1 && m.Data.Month == currentDate.Month).Sum(m => m.Valor);
        }
        public IList<Movimentacao> getMovimetacaoMes()
        {
            DateTime currentDate = DateTime.Now;
            return contexto.Movimentacoes.Where(m => m.Data.Month == currentDate.Month).ToList();
        }
    }
}