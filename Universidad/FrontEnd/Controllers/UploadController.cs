using Aplicacion.Aplicacion.Servicios.Interface;
using Dominio.Entidades;
using FrontEnd.Models;
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

        public UploadController(ICargaService<CampusExcel> cargaCampusService)
        {
            _cargaCampusService = cargaCampusService;
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

                var y = _cargaCampusService.ObtenerWorkSheet<CampusExcel>(file);

                //var z = _cargaCampusService.ObtenerListaWS<CampusExcel>(y);

                //if (file.ContentLength > 0)
                //{
                //    string _FileName = Path.GetFileName(file.FileName);
                //    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                //    file.SaveAs(_path);
                //}
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