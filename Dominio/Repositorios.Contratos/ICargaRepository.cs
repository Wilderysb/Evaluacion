using Dominio.Entidades.Carga;
using Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios.Contratos
{
    public interface ICargaRepository<TEntity> : IRepositoryBase<Carga>
    {
        bool SubirArchivo(TEntity T, string nombreArchivo);

    }
}
