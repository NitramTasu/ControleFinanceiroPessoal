using ControleFinanceiroData.DAO;
using ControleFinanceiroData.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroData
{
    class Program
    {
        static void Main(string[] args)
        {

            EntityContext contexto = new EntityContext();

            CategoriaDao dao = new CategoriaDao();
            Categoria categoria = new Categoria()
            {
                Descricao = "Informatica"
            };

            dao.Salvar(categoria);

            Console.WriteLine("Salvou");

        }
    }
}
