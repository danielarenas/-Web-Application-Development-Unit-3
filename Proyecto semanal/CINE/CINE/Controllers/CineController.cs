using CINE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CINE.Controllers
{
    public class CineController : Controller
    {
        readonly CineDBconnetion db= new CineDBconnetion();

        // GET: Cine
        public ActionResult Index() 
        { 


            var Clasificacions = db.Clasificacions.ToList();
            return View(Clasificacions);
            
        }
        public ActionResult Edit(int id)
        {
            var clasificacion = db.Clasificacions.Find(id);
            return View(clasificacion);
        }
                [HttpPost]

                public ActionResult Edit(int id, Clasificacion c)
                {
                    try
                    {
                        var clasificacion = db.Clasificacions.Find(id);

                clasificacion.Tipo = c.Tipo;
                clasificacion.Descripcion = c.Descripcion;
                db.SaveChanges();
                        return RedirectToAction("Index");
                        
                    
                    }
                    catch
                    {
                return View();
                    }

                }

         public ActionResult Delete(int id)
         {
           var clasificacion = db.Clasificacions.Find(id);

            return View(clasificacion);
         }
        // POST: Cine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Clasificacion c)
        {
            try
            {
                // TODO: Add delete logic here
                var clasificacion = db.Clasificacions.Find(id);
                db.Clasificacions.Remove(clasificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var clasificacion = db.Clasificacions.Find(id);
            return View(clasificacion);
        }
        // GET: Cine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cine/Create
        [HttpPost]
        public ActionResult Create(Clasificacion c)
        {
            try
            {
                // TODO: Add insert logic here
                db.Clasificacions.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
