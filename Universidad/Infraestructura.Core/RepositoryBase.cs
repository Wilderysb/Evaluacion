using Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Core
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected UniversidadContext _universidadContext;

        protected DbSet<TEntity> _DbSet;

        private bool disposed = false;

        public RepositoryBase(UniversidadContext universidadContext)
        {
            _universidadContext = universidadContext;
            _DbSet = _universidadContext.Set<TEntity>();
        }
        public virtual TEntity ObtenerPorId(int id)
        {
            return _DbSet.Find(id);
        }

        public virtual List<TEntity> ObtenerTodo()
        {
            return _universidadContext.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
