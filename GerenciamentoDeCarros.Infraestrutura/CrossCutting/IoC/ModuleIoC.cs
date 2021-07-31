using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Infraestrutura.CrossCutting.IoC
{
    public class ModuleIoC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IoC

            ConfiguracaoIoC.Load(builder);

            #endregion
        }
    }
}
