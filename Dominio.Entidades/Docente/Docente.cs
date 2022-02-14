using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Docente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string NombreDocente { get; set; }

        public string CodigoDocente { get; set; }

        public DocenteDto ConvertirDto()
        {
            return new DocenteDto()
            {
                Id = this.Id,
                NombreDocente = this.NombreDocente,
                CodigoDocente=this.CodigoDocente
            };
        }
    }
}
