using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using G4meroom.Models;
using Microsoft.AspNet.Identity;

namespace G4meroom
{
    public class AnunciosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Anuncios
        public ActionResult Index()
        {
            var meusAnuncios = db.Anuncios.Where(a => a.UserID.Equals(User.Identity.GetUserId()));

            return View(db.Anuncios.ToList());
        }

        // GET: Anuncios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncio anuncio = db.Anuncios.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        // GET: Anuncios/Create
        public ActionResult Create()
        {
            string idUsuarioLogando = User.Identity.GetUserId();
            if (idUsuarioLogando != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }

        // POST: Anuncios/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnuncioID,Produto,Descrição,Tipo,Valor,City,Country,State")] Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                string idUsuarioLogando = User.Identity.GetUserId();
                if (idUsuarioLogando != null)
                {
                    anuncio.UserID = idUsuarioLogando;
                    db.Anuncios.Add(anuncio);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return RedirectToAction("Login", "Account");
            }

            return View(anuncio);
        }

        // GET: Anuncios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncio anuncio = db.Anuncios.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        // POST: Anuncios/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnuncioID,Produto,Descrição,Tipo")] Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anuncio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anuncio);
        }

        // GET: Anuncios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncio anuncio = db.Anuncios.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        // POST: Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anuncio anuncio = db.Anuncios.Find(id);
            db.Anuncios.Remove(anuncio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
