using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class SubTipoEvento
    {
        [Key]
        public int Id { get; set; }

        public string DesSubTipoEvento { get; set; }

        [ForeignKey("IdTipoEvento")]
        public virtual TipoEvento TipoEventos { get; set; }
    }
}
