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
        private ISubTipoEventoService _subTipoEventoService;

        public HomeController(ITipoEventoService tipoEventoService,ICampusService campusService,ISubTipoEventoService subTipoEventoService)
        {
            _campusService = campusService;
            _tipoEventoService = tipoEventoService;
            _subTipoEventoService = subTipoEventoService;
        }
        public ActionResult Index()
        {
            var a = _campusService.ObtenerPorId(2);
            var b = _tipoEventoService.ObtenerTodo();
            var c = _subTipoEventoService.ObtenerTodoPorId(5);

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