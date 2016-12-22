using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleFinanceiroData.DAO;
using ControleFinanceiroData.Entidades;


namespace ControleFinanceiroPessoal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[Route("movimentacoes")]
        public ActionResult Index()
        {
            CategoriaDao categoriaDao = new CategoriaDao();


            IList<Categoria> categorias = categoriaDao.Categorias();

            ViewBag.Categorias = categorias;
            ViewBag.movimentacao = new Movimentacao();
            MovimentacaoDao movimentacaoDao = new MovimentacaoDao();
            IList<Movimentacao> movimentacoes = movimentacaoDao.getMovimetacaoMes();

            ViewBag.SomaMovRec = movimentacaoDao.getTotalEntradaMes();
            ViewBag.SomaMovDesp = movimentacaoDao.getTotalSaidaDoMes();

            ViewBag.TotalDespesa = movimentacaoDao.getDespesaTotal();
            ViewBag.TotalReceita = movimentacaoDao.getReceitaTotal();

            ViewBag.Movimentacoes = movimentacoes;
            
            
            
            return View();
        }
        
    }
}