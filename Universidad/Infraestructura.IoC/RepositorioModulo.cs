using Autofac;
using Dominio.Repositorios.Contratos;
using Infraestructura.Data;
using Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.IoC
{
    public class RepositorioModulo:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CampusRepository>().As<ICampusRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TipoEventoRepository>().As<ITipoEventoRepository>().InstancePerLifetimeScope();


        }
    }
}
