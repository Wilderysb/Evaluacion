﻿using System;
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

        [ForeignKey("IdTipoEvento")]
        public virtual TipoEvento TipoEventos { get; set; }

        [ForeignKey("IdSubTipoEvento")]
        public virtual SubTipoEvento SubTipoEventos { get; set; }
        //Se guarda la URL de la Imagen Seleccionada
        public string ImagenEvento { get; set; }
        public string OrganizadorEvento { get; set; }

        [ForeignKey("IdCampus")]
        public virtual Campus Campus { get; set; }
        public string URLArchivoEvento { get; set; }
        public int CapacidadEvento { get; set; }

        [ForeignKey("IdUbicacion")]
        public virtual Ubicacion UbiPresencialEvento { get; set; }
        public string UbiRemotaEvento { get; set; }





    }
}
