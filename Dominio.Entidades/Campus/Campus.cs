using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Campus
{
    public class Campus
    {
        [Key]
        public int Id { get; set; }
        public string NombreCampus { get; set; }
    }
}
