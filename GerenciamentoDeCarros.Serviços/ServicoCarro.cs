using GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços;
using GerenciamentoDeCarros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Serviços
{
    public class ServicoCarro : ServicoBase<Carro>, IServicoCarro
    {
        private readonly IRepositorioCarro repositorioCarro;
        public ServicoCarro(IRepositorioCarro repositorioCarro)
            : base(repositorioCarro)
        {
            this.repositorioCarro = repositorioCarro;
        }
    }
}
