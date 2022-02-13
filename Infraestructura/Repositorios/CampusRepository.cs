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
    
    public class CampusRepository : RepositoryBase<Campus>, ICampusRepository
    {

        public CampusRepository(UniversidadContext universidadContext):base(universidadContext)
        {

        }

        public override Campus ObtenerPorId(int id) {
            return _universidadContext.Campus.Where(p => p.IdCampus == id).SingleOrDefault();
        }

        public override List<Campus> ObtenerTodo() {
            return _universidadContext.Campus.ToList();
        }
        
    }
}
