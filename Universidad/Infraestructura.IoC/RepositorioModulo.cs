using Autofac;
using Dominio.Entidades;
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
            builder.RegisterType<SubTipoEventoRepository>().As<ISubTipoEventoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DocenteRepository>().As<IDocenteRepository>().InstancePerLifetimeScope();
            //Registro del Generico


            //builder.RegisterType<CargaRepository<>>().As<ICargaRepository<>>();
            builder.RegisterGeneric(typeof(CargaRepository<>)).As(typeof(ICargaRepository<>));
            //builder.RegisterType<ServiceA>().As<IService<MessageA>>().As<IService>();


            //builder.RegisterGeneric(typeof(CargaRepository<>)).As(typeof(ICargaRepository<>));
            //builder.RegisterType<CargaRepository>().As<ICargaRepository>().InstancePerLifetimeScope();

        }
    }
}
