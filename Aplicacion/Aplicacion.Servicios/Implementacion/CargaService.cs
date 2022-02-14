using Aplicacion.Aplicacion.Servicios.Interface;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Servicios.Implementacion
{
    public class CargaService<TEntity> : ICargaService<TEntity>
    {
        ICargaRepository<TEntity> _cargaRepository;

        public CargaService(ICargaRepository<TEntity> cargaRepository)
        {
            _cargaRepository = cargaRepository;
        }
        public bool CargarArchivo(TEntity T, string nombreArchivo)
        {
            _cargaRepository.SubirArchivo(T, nombreArchivo);

            return true;
        }
    }
}
