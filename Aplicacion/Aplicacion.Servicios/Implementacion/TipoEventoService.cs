using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Servicios.Implementacion
{
    public class TipoEventoService
    {
        ITipoEventoRepository _tipoEventoRepository;

        public TipoEventoService(ITipoEventoRepository tipoEventoRepository)
        {
            _tipoEventoRepository = tipoEventoRepository;
        }

        public TipoEventoDto ObtenerPorId(int id)
        {
            var tipoEvento = _tipoEventoRepository.ObtenerPorId(id);

            return tipoEvento != null ? tipoEvento.ConvertirDto() : null;
        }

        public List<TipoEventoDto> ObtenerTodo()
        {
            var listaTipoEvento = _tipoEventoRepository.ObtenerTodo();

            var query = from p in listaTipoEvento
                        select new TipoEventoDto { IdTipoEvento = p.IdTipoEvento, DesTipoEvento = p.DesTipoEvento };

            return query.ToList();
        }
    }
}
