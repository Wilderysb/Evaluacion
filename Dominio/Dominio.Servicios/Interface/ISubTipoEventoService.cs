using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dominio.Servicios.Interface
{
    public interface ISubTipoEventoService
    {
        List<SubTipoEvento> ObtenerTodoPorId(int id);

    }
}
