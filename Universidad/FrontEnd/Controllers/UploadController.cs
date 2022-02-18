using Aplicacion.Aplicacion.Servicios.Interface;
using Dominio.Entidades;
using FrontEnd.Models;
using FrontEnd.Models.ModelosExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class UploadController : Controller
    {
        private ICargaService <CampusExcel> _cargaCampusService;
        private ICargaService<AsistenciaEventoExcel> _cargaAsistenciaEventoService;

        public UploadController(ICargaService<CampusExcel> cargaCampusService,ICargaService<AsistenciaEventoExcel> cargaAsistenciaEventoService)
        {
            _cargaCampusService = cargaCampusService;
            _cargaAsistenciaEventoService = cargaAsistenciaEventoService;
        }
        
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                var x = file;

                var q = _cargaAsistenciaEventoService.ObtenerWorkSheet<AsistenciaEventoExcel>(file);
                
                ViewBag.Message = "File Uploaded Successfully!!";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }


    }
}