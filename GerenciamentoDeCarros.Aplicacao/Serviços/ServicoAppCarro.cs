using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Aplicacao.Interfaces;
using GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Aplicacao.Serviços
{
    public class ServicoAppCarro : IAppCarro
    {
        private readonly IServicoCarro servicoCarro;
        private readonly IMapperCarro mapperCarro;
        public ServicoAppCarro(IServicoCarro servicoCarro, IMapperCarro mapperCarro)
        {
            this.servicoCarro = servicoCarro;
            this.mapperCarro = mapperCarro;
        }

        public void Alterar(CarroDto carroDto)
        {
            var carro = mapperCarro.MapperDtoToEntity(carroDto);
            servicoCarro.Alterar(carro);
        }

        public CarroDto BuscarPorId(int id)
        {
            var carro = servicoCarro.BuscarPorId(id);
            return mapperCarro.MapperEntityToDto(carro);
        }

        public CarroDto BuscarPorNome(string nome)
        {
            var carro = servicoCarro.BuscarPorNome(nome);
            return mapperCarro.MapperEntityToDto(carro);
        }

        public void Excluir(CarroDto carroDto)
        {
            var carro = mapperCarro.MapperDtoToEntity(carroDto);
            servicoCarro.Excluir(carro);
        }

        public void Incluir(CarroDto carroDto)
        {
            var carro = mapperCarro.MapperDtoToEntity(carroDto);
            servicoCarro.Incluir(carro);
        }

        public IEnumerable<CarroDto> Listar()
        {
            var carros = servicoCarro.Listar();
            return mapperCarro.MapperListCarroDto(carros);
        }
    }
}
