using Dominio.Dominio.Servicios.Interface;
using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dominio.Servicios.Implementacion
{
    public class DocenteService : IDocenteService
    {
        IDocenteRepository _docenteRepository;

        public DocenteService(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }
        public List<Docente> ObtenerTodo()
        {
            return _docenteRepository.ObtenerTodo();
        }
    }
}
