using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Areas.Eventos.Controllers
{
    public class EventoController : Controller
    {
        // GET: Eventos/Evento
        public ActionResult Index()
        {
            return View();
        }
    }
}