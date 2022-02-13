using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public string NombreEvento { get; set; }
        public string DetalleEvento { get; set; }

        public int IdTipoEvento { get; set; }

        [ForeignKey("IdTipoEvento")]
        public virtual TipoEvento TipoEvento { get; set; }

        public int IdSubTipoEvento { get; set; }

        [ForeignKey("IdSubTipoEvento")]
        public virtual SubTipoEvento SubTipoEvento { get; set; }
        //Se guarda la URL de la Imagen Seleccionada
        public string ImagenEvento { get; set; }
        public string OrganizadorEvento { get; set; }

        public int IdCampus { get; set; }

        [ForeignKey("IdCampus")]
        public virtual Campus Campus { get; set; }
        public string URLArchivoEvento { get; set; }
        public int CapacidadEvento { get; set; }

        public int IdUbicacion { get; set; }

        [ForeignKey("IdUbicacion")]
        public virtual Ubicacion Ubicacion { get; set; }
        public string UbiRemotaEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime HoraInicioEvento { get; set; }
        public DateTime HoraFinEvento { get; set; }


    }
}
