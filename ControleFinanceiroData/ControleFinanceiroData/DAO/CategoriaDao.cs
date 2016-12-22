using ControleFinanceiroData.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinanceiroData.DAO
{
    public class CategoriaDao
    {
        EntityContext contexto;
        
        public CategoriaDao()
        {
            this.contexto = new EntityContext();
        }
        public void Salvar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public void Remover(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            contexto.SaveChanges();
        }
        public Categoria BuscaPorId(int id )
        {
            return contexto.Categorias.FirstOrDefault(c => c.Id == id);
        }

        public Categoria UltimoRegistro()
        {
            return contexto.Categorias.LastOrDefault();
        }
        public IList<Categoria> Categorias()
        {
            return contexto.Categorias.ToList();
        }
        
    }
}