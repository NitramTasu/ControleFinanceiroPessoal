using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleFinanceiroData.DAO;
using ControleFinanceiroData.Entidades;

namespace ControleFinanceiroPessoal.Controllers
{
    public class MovimentacaoController : Controller
    {
        
        // GET: Home
        //[Route("movimentacoes")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(Movimentacao m)
        {
            MovimentacaoDao movimentacaoDao = new MovimentacaoDao();
            IList<Movimentacao> movimentacoes = movimentacaoDao.getMovimetacaoMes();
            CategoriaDao categoriaDao = new CategoriaDao();
            IList<Categoria> categorias = categoriaDao.Categorias();

            ViewBag.Categorias = categorias;
            return View(movimentacoes);
        }

        [HttpPost]
        public ActionResult Adiciona(Movimentacao movimentacao)
        {
            MovimentacaoDao movimentacaoDAO = new MovimentacaoDao();

            movimentacaoDAO.Adicionar(movimentacao);

            return View();
        }

        
        public ActionResult Remover(int id)
        {
            
            MovimentacaoDao movimentacaoDao = new MovimentacaoDao();
            Movimentacao mov = movimentacaoDao.BuscarPorId(id);

            movimentacaoDao.Remover(mov);

            return Json(mov);

            
        }
    }
}