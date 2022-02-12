using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext() : base("DefaultConnection")
        {
            Database.SetInitializer<UniversidadContext>(null);
           // Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<AsistenciaEvento> AsistenciaEvento { get;set; }
        public virtual DbSet<Campus> Campus { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<SubTipoEvento> SubTipoEvento { get; set; }
        public virtual DbSet<TipoEvento> TipoEvento { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }

    }
}
