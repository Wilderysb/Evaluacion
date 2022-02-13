using Aplicacion.Aplicacion.Servicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontNet.Controllers
{
    public class HomeController : Controller
    {
        private ICampusService _campusService;

        public HomeController(ICampusService campusService)
        {
            _campusService = campusService;
        }
        public ActionResult Index()
        {
            var x = _campusService.ObtenerTodo();

            return View();
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