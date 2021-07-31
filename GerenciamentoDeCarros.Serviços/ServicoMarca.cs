using GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços;
using GerenciamentoDeCarros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Serviços
{
    public class ServicoMarca : ServicoBase<Marca>, IServicoMarca
    {
        private readonly IRepositorioMarca repositorioMarca;
        public ServicoMarca(IRepositorioMarca repositorioMarca)
            : base(repositorioMarca)
        {
            this.repositorioMarca = repositorioMarca;
        }
    
    }
}
