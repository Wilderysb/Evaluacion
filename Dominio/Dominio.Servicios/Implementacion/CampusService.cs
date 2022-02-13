using Dominio.Dominio.Servicios.Interface;
using Dominio.Entidades;
using Dominio.Repositorios.Contratos;
using System;
using System.Collections.Generic;


namespace Dominio.Dominio.Servicios.Implementacion
{
    public class CampusService : ICampusService
    {
        ICampusRepository _campusRepository;

        public CampusService(ICampusRepository campusRepository)
        {
            _campusRepository = campusRepository;
        }

        public Campus ObtenerPorId(int id)
        {
            return _campusRepository.ObtenerPorId(id);
        }

        public List<Campus> ObtenerTodo()
        {
            return _campusRepository.ObtenerTodo();
        }
    }
}
