using Aula0706_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula0706_MVC.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros", Descricao = "Super carros de coleção." });
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "Motos esportivas." });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Barcos luxuosos." });
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "Aviões de guerra." });
            categorias.Add(new Categoria() { Nome = "Caminhões", Descricao = "Caminhões de areia." });

            ViewBag.ListaCategorias = categorias;

            return View(categorias);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}