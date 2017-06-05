using AvaliacaoAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoAspNet.Controllers
{
    public class TiposControllers:BaseController
    {

        static public void Adicionar(Tipo Tipo)
        {
            if (Tipo != null)
            {
                contexto.Tipo.Add(Tipo);
                contexto.SaveChanges();
            }
        }

        static public void Excluir(Tipo Tipo)
        {
            contexto.Entry(Tipo).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        static public void Editar(Tipo Tipo)
        {
            contexto.Entry(Tipo).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        static public List<Tipo> ListarTipos()
        {
            return contexto.Tipo.OrderBy(x => x.Nome).ToList();
        }

        static public Tipo BuscarPorNome(Tipo Tipo)
        {
            return contexto.Tipo.FirstOrDefault(x => x.Nome.Equals(Tipo.Nome));
        }
    }
}