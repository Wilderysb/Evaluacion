using Autofac;
using Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.IoC
{
    public class EFModulo :Module
    {
        protected override void Load (ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositorioModulo());

            builder.RegisterType<UniversidadContext>().AsSelf().InstancePerRequest();


        }

    }
}
