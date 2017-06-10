using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirst.Models;

namespace MVCFirst.Controllers
{
    public class GraController : Controller
    {
        // GET: Gra
        public ActionResult Index() {
            var gry = RepositoryGry.GetAll();
            return View(gry);
        }
    }
}