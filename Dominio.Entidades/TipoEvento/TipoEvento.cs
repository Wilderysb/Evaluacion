using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class TipoEvento
    {
        [Key]
        public int IdTipoEvento { get; set; }
        public string DesTipoEvento { get; set; }
       
        // public virtual List<SubTipoEvento> SubTipoEventos { get; set; }       
        public virtual List<Evento> Eventos { get; set; }

        public TipoEventoDto ConvertirDto()
        {
            return new TipoEventoDto()
            {
                IdTipoEvento = this.IdTipoEvento,
                DesTipoEvento = this.DesTipoEvento
            };
        }
    }
}
