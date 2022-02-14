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
        public int IdSubTipoEvento { get; set; }

        public string DesSubTipoEvento { get; set; }

        //public virtual List<Evento> Eventos { get; set; }

        public SubTipoEventoDto ConvertirDto()
        {
            return new SubTipoEventoDto()
            {
                IdSubTipoEvento = this.IdSubTipoEvento,
                DesSubTipoEvento = this.DesSubTipoEvento
            };
        }
    }
}
