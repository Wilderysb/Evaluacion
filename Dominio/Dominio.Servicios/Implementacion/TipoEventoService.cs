using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dominio.Servicios.Implementacion
{
    public class TipoEventoService
    {
        ITipoEventoRepository _tipoEventoRepository;

        public TipoEventoService(ITipoEventoRepository tipoEventoRepository)
        {
            _tipoEventoRepository = tipoEventoRepository;
        }

        public TipoEvento ObtenerPorId(int id)
        {
            return _tipoEventoRepository.ObtenerPorId(id);
        }

    }
}
