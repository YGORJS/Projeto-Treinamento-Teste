using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleDeProgramacoes.Models;
using Dominio;

namespace ControleDeProgramacoes.Controllers
{
    public class ObrasController : Controller
    {
        private ControleDeProgramacoesContext db = new ControleDeProgramacoesContext();

        // GET: Obras
        public ActionResult Index()
        {
            return View(db.Obras.ToList());
        }

        // GET: Obras/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obra obra = db.Obras.Find(id);
            if (obra == null)
            {
                return HttpNotFound();
            }
            return View(obra);
        }

        // GET: Obras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Obras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnoLancamento,Descricao,Classificacao,Genero")] Obra obra)
        {
            if (ModelState.IsValid)
            {
                db.Obras.Add(obra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obra);
        }

        // GET: Obras/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obra obra = db.Obras.Find(id);
            if (obra == null)
            {
                return HttpNotFound();
            }
            return View(obra);
        }

        // POST: Obras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnoLancamento,Descricao,Classificacao,Genero")] Obra obra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obra);
        }

        // GET: Obras/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obra obra = db.Obras.Find(id);
            if (obra == null)
            {
                return HttpNotFound();
            }
            return View(obra);
        }

        // POST: Obras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Obra obra = db.Obras.Find(id);
            db.Obras.Remove(obra);
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
