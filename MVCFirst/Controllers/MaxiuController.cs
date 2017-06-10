using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirst.Models;


namespace MVCFirst.Controllers
{
    public class MaxiuController : Controller
    {
        // GET: Maxiu
        public ActionResult Index() {
            ViewBag.message = "Ala ma kota";
            return View();
        }

        public ActionResult Index2() {
            Workers dbWorkers = new Workers();
            List<Worker> lista = dbWorkers.GetAll();
            return View(lista);
        }

        public ActionResult SelectWorker() {
            Workers dbWorkers = new Workers();
            List<Worker> lista = dbWorkers.GetAll();
            return View(lista);
        }
    }
}