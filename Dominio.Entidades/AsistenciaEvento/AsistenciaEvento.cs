using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.AsistenciaEvento
{
    public class AsistenciaEvento
    {
        [Key]
        public int Id { get; set; }
        public string CodigoAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApePaternoAlumno { get; set; }
        public string ApeMaternoAlumno { get; set; }
        public string MailAlumno { get; set; }
        public string TelefonoAlumno { get; set; }

    }
}
