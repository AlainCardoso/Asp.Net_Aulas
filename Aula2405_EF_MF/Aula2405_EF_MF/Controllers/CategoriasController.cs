using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aula2405_EF_MF.Models;

namespace Aula2405_EF_MF.Controllers
{
    public class CategoriasController
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();
        public void Adicionar(Categoria categoria)
        {
            if (categoria != null)
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }
        public List<Categoria> Listar()
        {
            // Retorna todas as categorias ativas.
            return contexto.Categorias.Where(c => c.Ativo == true).OrderBy(c => c.Nome).ToList();
        }
        public List<Categoria> ListarInativos()
        {
            // Retorna todas as categorias inativos.
            return contexto.Categorias.Where(c => c.Ativo == false).ToList();
        }
        public Categoria BuscarCategoriaPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }
        // Exclusão física (apaga o registro do banco.
        //public void Excluir(Categoria categoria)
        //{
        //    contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
        //    contexto.SaveChanges();
        //}

        // Exclusão logica (campo Ativo/Inativo).
        public void Excluir (Categoria categoria)
        {
            categoria.Ativo = false;

            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
        }
    }
}