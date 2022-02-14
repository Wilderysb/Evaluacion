using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Carga
{
    public class Carga
    {
        [Key]
        public int IdCarga { get; set; }

        public string DesCarga { get; set; }

    }
}
