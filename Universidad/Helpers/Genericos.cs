using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Genericos<TEntity>
    {
        public TEntity GetObject<T>(params object[] lstArgument) {
            return (TEntity)Activator.CreateInstance(typeof(T), lstArgument);
        
        }

    }
}
