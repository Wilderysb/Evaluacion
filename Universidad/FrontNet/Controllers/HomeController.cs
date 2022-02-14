﻿using Aplicacion.Aplicacion.Servicios.Interface;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FrontNet.Controllers
{
    public class HomeController : Controller
    {
        private ICampusService _campusService;
        private ITipoEventoService _tipoEventoService;
        private ISubTipoEventoService _subTipoEventoService;
        private IDocenteService _docenteService;

        public HomeController(ITipoEventoService tipoEventoService,
            ICampusService campusService,
            ISubTipoEventoService subTipoEventoService,
            IDocenteService docenteService
            )
        {
            _campusService = campusService;
            _tipoEventoService = tipoEventoService;
            _subTipoEventoService = subTipoEventoService;
            _docenteService = docenteService;
        }
        public ActionResult Index()
        {
            //var a = _campusService.ObtenerPorId(2); //Obtener Campus
            //var b = _tipoEventoService.ObtenerTodo(); // Obtener Tipos
            //var c = _subTipoEventoService.ObtenerTodoPorId(5); // Obtener Subtipos
            //var d = _docenteService.ObtenerTodo(); //Obtener Docente

            // Consumo de API
            ClienteHttp clienteHttp = new ClienteHttp();
            var BaseUrl = "https://apifake.azurewebsites.net/";
            //Servicio de Fake Publicado.
            //var e = clienteHttp.ObtenerRespuesta(BaseUrl);

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