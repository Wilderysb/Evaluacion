using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Core
{
    public interface IRepositoryBase<TEntity> where TEntity:class
    {
       TEntity ObtenerPorId(int id);
       List<TEntity> ObtenerTodo();        
    }
}
