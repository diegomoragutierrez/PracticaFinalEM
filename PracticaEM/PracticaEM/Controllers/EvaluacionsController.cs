using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PracticaEM.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PracticaEM.Controllers
{
    public class EvaluacionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Evaluacions
        public ActionResult Index()
        {
            var evaluacions = db.Evaluacions.Include(e => e.User);
            return View(evaluacions.ToList());
        }

        // GET: Evaluacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // GET: Evaluacions/Create
        public ActionResult Create()
        {
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            List<ApplicationUser> users = new List<ApplicationUser>();
            foreach (ApplicationUser user in db.Users.ToList())
            {
                foreach (String rol in userMgr.GetRoles(user.Id))
                {
                    if (rol.Equals("alumno"))
                    {
                        users.Add(user);
                    }
                }
            }
            ViewBag.UserId = new SelectList(users, "Id", "Email");
            return View();
        }

        // POST: Evaluacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvaluacionId,NotaT1,NotaT2,NotaT3,NotaPr,NotaTest,Convocatoria,UserId")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Evaluacions.Add(evaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", evaluacion.UserId);
            return View(evaluacion);
        }

        // GET: Evaluacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            List<ApplicationUser> users = new List<ApplicationUser>();
            foreach (ApplicationUser user in db.Users.ToList())
            {
                foreach (String rol in userMgr.GetRoles(user.Id))
                {
                    if (rol.Equals("alumno"))
                    {
                        users.Add(user);
                    }
                }
            }
            ViewBag.UserId = new SelectList(users, "Id", "Email", evaluacion.User.Id);
            return View(evaluacion);
        }

        // POST: Evaluacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvaluacionId,NotaT1,NotaT2,NotaT3,NotaPr,NotaTest,Convocatoria,UserId")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", evaluacion.UserId);
            return View(evaluacion);
        }

        // GET: Evaluacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // POST: Evaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            db.Evaluacions.Remove(evaluacion);
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
