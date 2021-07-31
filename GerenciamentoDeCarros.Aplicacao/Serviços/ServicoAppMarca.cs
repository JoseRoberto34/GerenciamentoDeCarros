using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Aplicacao.Interfaces;
using GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Text;
namespace GerenciamentoDeCarros.Aplicacao.Serviços
{
    public class ServicoAppMarca : IAppMarca
    {
        private readonly IServicoMarca servicoMarca;
        private readonly IMapperMarca mapperMarca;
        public ServicoAppMarca(IServicoMarca servicoMarca, IMapperMarca mapperMarca)
        {
            this.servicoMarca = servicoMarca;
            this.mapperMarca = mapperMarca;
        }

        public void Alterar(MarcaDto marcaDto)
        {
            var marca = mapperMarca.MapperDtoToEntity(marcaDto);
            servicoMarca.Alterar(marca);
        }

        public MarcaDto BuscarPorId(int id)
        {
            var marca = servicoMarca.BuscarPorId(id);
            return mapperMarca.MapperEntityToDto(marca);
        }

        public MarcaDto BuscarPorNome(string nome)
        {
            var marca = servicoMarca.BuscarPorNome(nome);
            return mapperMarca.MapperEntityToDto(marca);
        }

        public void Excluir(MarcaDto marcaDto)
        {
            var marca = mapperMarca.MapperDtoToEntity(marcaDto);
            servicoMarca.Excluir(marca);
        }

        public void Incluir(MarcaDto marcaDto)
        {
            var marca = mapperMarca.MapperDtoToEntity(marcaDto);
            servicoMarca.Incluir(marca);
        }

        public IEnumerable<MarcaDto> Listar()
        {
            var marcas = servicoMarca.Listar();
            return mapperMarca.MapperListMarcaDto(marcas);
        }
    }
}
