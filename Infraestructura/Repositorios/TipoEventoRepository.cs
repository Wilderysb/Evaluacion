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
    public class TipoEventoRepository : RepositoryBase<TipoEvento>, ITipoEventoRepository
    {
        public TipoEventoRepository(UniversidadContext universidadContext) : base(universidadContext)
        {

        }

        

    }
}
