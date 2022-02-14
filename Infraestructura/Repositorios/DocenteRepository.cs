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
    public class DocenteRepository :RepositoryBase<Docente>, IDocenteRepository
    {
        public DocenteRepository(UniversidadContext universidadContext) : base(universidadContext)
        {

        }
        public override List<Docente> ObtenerTodo()
        {
            return _universidadContext.Docente.ToList();
        }
    }
}
