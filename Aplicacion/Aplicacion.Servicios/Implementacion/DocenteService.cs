using Aplicacion.Aplicacion.Servicios.Interface;
using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Servicios.Implementacion
{
    public class DocenteService : IDocenteService
    {
        IDocenteRepository _docenteRepository;
        public DocenteService(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }
        public List<DocenteDto> ObtenerTodo()
        {
            var listaDocente = _docenteRepository.ObtenerTodo();

            var query = from p in listaDocente
                        select new DocenteDto { Id = p.Id, NombreDocente = p.NombreDocente,CodigoDocente=p.CodigoDocente };

            return query.ToList();
        }
    }
}
