using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Aplicacion.Aplicacion.Servicios.Interface
{
    public interface ICargaService<TEntity> 
    {        
        List<T> ObtenerWorkSheet<T>(HttpPostedFileBase httpPostedFileBase);
    }
}
