using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Servicios.Interface
{
    public interface ICargaService<TEntity>
    {
        bool CargarArchivo(TEntity T, string nombreArchivo);
    }
}
