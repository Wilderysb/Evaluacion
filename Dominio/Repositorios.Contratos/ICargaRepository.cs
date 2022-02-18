using Dominio.Entidades.Carga;
using Infraestructura.Core;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dominio.Repositorios.Contratos
{
    public interface ICargaRepository<TEntity> : IRepositoryBase<Carga>
    {
        List<T> ObtenerWorkSheet<T>(HttpPostedFileBase httpPostedFileBase);


    }
}
