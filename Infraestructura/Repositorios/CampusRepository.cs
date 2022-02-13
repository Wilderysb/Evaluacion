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
            return _universidadContext.Campus.FirstOrDefault();
        }

        public override List<Campus> ObtenerTodo() {
            return _universidadContext.Campus.ToList();
        }

            
        //public override Campus ObtenerPorId(int id)
        //{
        //    return universidadContext.Campus.SingleOrDefault(q=>q.Id==id);
        //}
        
        //public override List<Campus> ObtenerTodo()
        //{
        //    return universidadContext.Campus.ToList();
        //}
    }
}
