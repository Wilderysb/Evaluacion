using Dominio.Entidades.Carga;
using Dominio.Repositorios.Contratos;
using Infraestructura.Core;
using Infraestructura.Data;

namespace Infraestructura.Repositorios
{
    public class CargaRepository<TEntity> :RepositoryBase<Carga> , ICargaRepository<TEntity> where TEntity :class 
    {
        public CargaRepository(UniversidadContext universidadContext) : base(universidadContext)
        {

        }

        public bool SubirArchivo(TEntity T, string nombreArchivo)
        {
            string[] estructuraGeneral = new string [] { };

            foreach (var propiedad in T.GetType().GetProperties())
            {
                var propiedadNombre = propiedad.Name;
                var propiedadValor = propiedad.GetValue(T);
                
            }
            return true;
        }
    }
}
