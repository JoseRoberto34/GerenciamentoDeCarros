
using Autofac;
using GerenciamentoDeCarros.Aplicacao.Interfaces;
using GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper;
using GerenciamentoDeCarros.Aplicacao.Mapper;
using GerenciamentoDeCarros.Aplicacao.Serviços;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços;
using GerenciamentoDeCarros.Infraestrutura.Data.Repositorios;
using GerenciamentoDeCarros.Serviços;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Infraestrutura.CrossCutting.IoC
{
    public class ConfiguracaoIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IoC

            builder.RegisterType<ServicoAppCarro>().As<IAppCarro>();
            builder.RegisterType<ServicoAppMarca>().As<IAppMarca>();
            builder.RegisterType<ServicoCarro>().As<IServicoCarro>();
            builder.RegisterType<ServicoMarca>().As<IServicoMarca>();
            builder.RegisterType<RepositorioCarro>().As<IRepositorioCarro>();
            builder.RegisterType<RepositorioMarca>().As<IRepositorioMarca>(); 
            builder.RegisterType<MapperCarro>().As<IMapperCarro>();
            builder.RegisterType<MapperMarca>().As<IMapperMarca>();
            #endregion
        }
    }
}