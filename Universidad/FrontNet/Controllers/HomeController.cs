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
        private ITipoEventoService _tipoEventoService;

        public HomeController(ITipoEventoService tipoEventoService,ICampusService campusService)
        {
            _campusService = campusService;
            _tipoEventoService = tipoEventoService;
        }
        public ActionResult Index()
        {
            var x = _campusService.ObtenerPorId(2);
            var y = _tipoEventoService.ObtenerTodo();

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