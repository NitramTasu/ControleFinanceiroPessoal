using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleFinanceiroData.DAO;
using ControleFinanceiroData.Entidades;
using ControleFinanceiroData;

namespace ControleFinanceiroPessoal.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {

            loadCategorias();

            return View();
        }

        private void loadCategorias()
        {
            CategoriaDao daoC = new CategoriaDao();
            IList<Categoria> categorias = daoC.Categorias();

            ViewBag.Categorias = categorias;
        }

        [HttpPost]
        public ActionResult Adicionar(Categoria c)
        {
           
            CategoriaDao daoC = new CategoriaDao();

            daoC.Salvar(c);

            //return RedirectToAction("Index","Categoria");
            return Json(c);   
        }

        public ActionResult Remover(int id)
        {
            CategoriaDao daoC = new CategoriaDao();

            Categoria c = daoC.BuscaPorId(id);
            daoC.Remover(c);
            return Json(c);
        }

       

    }
}