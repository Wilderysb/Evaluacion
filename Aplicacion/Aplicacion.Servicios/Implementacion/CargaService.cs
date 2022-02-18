using Aplicacion.Aplicacion.Servicios.Interface;
using Dominio.Repositorios.Contratos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Aplicacion.Aplicacion.Servicios.Implementacion
{
    public class CargaService<TEntity> : ICargaService<TEntity> where TEntity:class
    {
        
        ICargaRepository<TEntity> _cargaRepository;

        public CargaService(ICargaRepository<TEntity> cargaRepository)
        {
            _cargaRepository = cargaRepository;
        }

        public ExcelWorksheet ObtenerWorkSheet(HttpPostedFileBase httpPostedFileBase)
        {
           return _cargaRepository.ObtenerWorkSheet(httpPostedFileBase);
        }
        //public bool CargarArchivo(TEntity T,string nombreArchivo)
        //{
        //    _cargaRepository.SubirArchivo(T, nombreArchivo);

        //    return true;
        //}
    }
}
