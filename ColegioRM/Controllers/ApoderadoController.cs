using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ColegioRM.ModelsE;

namespace ColegioRM.Controllers
{
    public class ApoderadoController : Controller
    {
        private ColegioRMEntities1 db = new ColegioRMEntities1();

        // GET: Apoderadoes
        public ActionResult Index()
        {
            return View(db.Apoderado.ToList());
        }

        // GET: Apoderadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apoderado apoderado = db.Apoderado.Find(id);
            if (apoderado == null)
            {
                return HttpNotFound();
            }
            return View(apoderado);
        }

        // GET: Apoderadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apoderadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idApoderado,codApoderado,apPaterno,apMaterno,nombres,correo,telefono,dateNac,direccion,sexo")] Apoderado apoderado)
        {
            if (ModelState.IsValid)
            {
                db.Apoderado.Add(apoderado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apoderado);
        }

        // GET: Apoderadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apoderado apoderado = db.Apoderado.Find(id);
            if (apoderado == null)
            {
                return HttpNotFound();
            }
            return View(apoderado);
        }

        // POST: Apoderadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idApoderado,codApoderado,apPaterno,apMaterno,nombres,correo,telefono,dateNac,direccion,sexo")] Apoderado apoderado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apoderado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apoderado);
        }

        // GET: Apoderadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apoderado apoderado = db.Apoderado.Find(id);
            if (apoderado == null)
            {
                return HttpNotFound();
            }
            return View(apoderado);
        }

        // POST: Apoderadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apoderado apoderado = db.Apoderado.Find(id);
            db.Apoderado.Remove(apoderado);
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
