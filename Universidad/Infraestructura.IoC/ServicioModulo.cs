using Aplicacion.Aplicacion.Servicios.Implementacion;
using Aplicacion.Aplicacion.Servicios.Interface;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.IoC
{
    public class ServicioModulo:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CampusService>().As<ICampusService>().InstancePerLifetimeScope();
            builder.RegisterType<TipoEventoService>().As<ITipoEventoService>().InstancePerLifetimeScope();
            builder.RegisterType<SubTipoEventoService>().As<ISubTipoEventoService>().InstancePerLifetimeScope();
            builder.RegisterType<DocenteService>().As<IDocenteService>().InstancePerLifetimeScope();


        }

    }
}
