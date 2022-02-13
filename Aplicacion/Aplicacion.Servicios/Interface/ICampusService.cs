using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Servicios.Interface
{
    public interface ICampusService
    {
        CampusDto ObtenerPorId(int id);
        List<Campus> ObtenerTodo();
    }
}
