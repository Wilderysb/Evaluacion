using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Ubicacion
    {
        [Key]
        public int IdUbicacion { get; set; }
        public string Espacio { get; set; }
        public virtual List<Evento> Eventos { get; set; }

    }
}
