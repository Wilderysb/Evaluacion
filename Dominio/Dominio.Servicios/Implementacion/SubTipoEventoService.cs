using Dominio.Dominio.Servicios.Interface;
using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dominio.Servicios.Implementacion
{
    public class SubTipoEventoService : ISubTipoEventoService
    {
        ISubTipoEventoRepository _subTipoEventoRepository;

        public SubTipoEventoService(ISubTipoEventoRepository subTipoEventoRepository)
        {
            _subTipoEventoRepository = subTipoEventoRepository;
        }
        public List<SubTipoEvento> ObtenerTodoPorId(int id)
        {
            return _subTipoEventoRepository.ObtenerTodoPorId(id);
        }
    }
}
