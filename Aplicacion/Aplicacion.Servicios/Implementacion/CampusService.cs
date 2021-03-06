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
    public class CampusService : ICampusService
    {
        ICampusRepository _campusRepository;

        public CampusService(ICampusRepository campusRepository)
        {
            _campusRepository = campusRepository;
        }

        public CampusDto ObtenerPorId(int id)
        {
            var campus = _campusRepository.ObtenerPorId(id);

            return campus != null ? campus.ConvertirDto() : null;
        }

        public List<CampusDto> ObtenerTodo()
        {
            var listaCampus = _campusRepository.ObtenerTodo();
            
            var query= from p in listaCampus
                       select new CampusDto{Id= p.IdCampus,NombreCampus=p.NombreCampus};

            return query.ToList();
        }
    }
}
