using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dominio.Dominio.Servicios.Interface
{
    public interface ICargaService<TEntity>
    {
        ExcelWorksheet ObtenerWorkSheet(HttpPostedFileBase httpPostedFileBase);
    }
}
