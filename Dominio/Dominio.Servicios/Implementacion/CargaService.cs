using Dominio.Dominio.Servicios.Interface;
using Dominio.Repositorios.Contratos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dominio.Dominio.Servicios.Implementacion
{
    public class CargaService<TEntity> : ICargaService<TEntity>
    {
        public ICargaRepository<TEntity> _cargaRepository;

        public CargaService(ICargaRepository<TEntity> cargaRepository)
        {
            _cargaRepository = cargaRepository;

        }

        public List<T> ObtenerWorkSheet<T>(HttpPostedFileBase httpPostedFileBase)
        {
            return _cargaRepository.ObtenerWorkSheet<T>(httpPostedFileBase);
        }

    }
}
