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

namespace PracticaEM.Controllers
{
    [Authorize(Roles = "alumno")]
    public class MiEvaluacionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MiEvaluacions
        public ActionResult Index()
        {
            List<Evaluacion> evals = new List<Evaluacion>();
            foreach (Evaluacion eval in db.Evaluacions.ToList())
            {
                if(eval.UserId == User.Identity.GetUserId()){
                     evals.Add(eval);
                }
            }
            return View(evals);
        }

        // GET: MiEvaluacions/Details/5
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
        
    }
}
