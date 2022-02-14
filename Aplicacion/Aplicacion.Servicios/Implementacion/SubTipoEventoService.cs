using Aplicacion.Aplicacion.Servicios.Interface;
using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Servicios.Implementacion
{
    public class SubTipoEventoService:ISubTipoEventoService
    {

        ISubTipoEventoRepository _subTipoEventoRepository;

        public SubTipoEventoService(ISubTipoEventoRepository subTipoEventoRepository)
        {
            _subTipoEventoRepository = subTipoEventoRepository;
        }

      
        public List<SubTipoEventoDto> ObtenerTodoPorId(int id)
        {
            var listaSubTipoEvento = _subTipoEventoRepository.ObtenerTodoPorId(id);

            var query = from p in listaSubTipoEvento
                        select new SubTipoEventoDto { IdSubTipoEvento = p.IdSubTipoEvento, DesSubTipoEvento = p.DesSubTipoEvento };

            return query.ToList();
        }
    }
}
