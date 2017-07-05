using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            //Retornar a lista de objetos cadastrados
            return View(categorias);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Create(Categoria Categoria, FormCollection campos)
        {
            if (ModelState.IsValid)
            {
                // insert

            }
            return View(Categoria);
        }

        public ActionResult Edit (int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                // update
            }

            return View(categoria);
        }
    }
}