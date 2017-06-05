using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AvaliacaoAspNet.Models;

namespace AvaliacaoAspNet.Controllers
{
    public class AkumaNoMisController:BaseController
    {

        static public void Adicionar(AkumaNoMi Ak)
        {
            if (Ak != null)
            {
                contexto.AkumaNoMi.Add(Ak);
                contexto.SaveChanges();
            }
        }

        static public void Excluir(AkumaNoMi Ak)
        {
            contexto.Entry(Ak).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        static public void Editar(AkumaNoMi Ak)
        {
            contexto.Entry(Ak).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        static public List<AkumaNoMi> ListarConsumidos()
        {
            return contexto.AkumaNoMi.Where(x => x.Consumido == true).ToList();
        }

        static public List<AkumaNoMi> ListarNãoConsumidos()
        {
            return contexto.AkumaNoMi.Where(x => x.Consumido == false).ToList();
        }

        static public AkumaNoMi BuscarPorNome(AkumaNoMi Ak)
        {
            return contexto.AkumaNoMi.FirstOrDefault(x => x.Nome.Equals(Ak.Nome));
        }
    }
}