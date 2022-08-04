using DbFirst.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbFirst.Controllers
{
    
    public class HomeController : Controller
    {
        AppDbContext context = new AppDbContext();
        private readonly Logic _logica;
        public HomeController()
        {
            _logica = new Logic();
        }
        public ActionResult Index()
        {
            var list = new List<RDR1>();
            list = _logica.Buscar_lista_productos(2);
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}