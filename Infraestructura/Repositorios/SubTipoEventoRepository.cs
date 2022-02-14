using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using Infraestructura.Core;
using Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class SubTipoEventoRepository :RepositoryBase<SubTipoEvento>, ISubTipoEventoRepository
    {
        public SubTipoEventoRepository(UniversidadContext universidadContext) : base(universidadContext)
        {

        }

        public List<SubTipoEvento> ObtenerTodoPorId(int id)
        {
            List<SubTipoEvento> listaSubTipoEventos = new List<SubTipoEvento>();

            if (id == 1 || id == 2)
            {
                listaSubTipoEventos = _universidadContext.SubTipoEvento.Where(p => p.IdSubTipoEvento == 1 || p.IdSubTipoEvento == 2).ToList();
            }
            else
            {
                listaSubTipoEventos = _universidadContext.SubTipoEvento.ToList();
            }

            return listaSubTipoEventos;
                       
        }
    }
}
