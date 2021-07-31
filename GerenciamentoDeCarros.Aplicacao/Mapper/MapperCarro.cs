using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper;
using GerenciamentoDeCarros.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
namespace GerenciamentoDeCarros.Aplicacao.Mapper
{
    public class MapperCarro : IMapperCarro
    {
        public Carro MapperDtoToEntity(CarroDto carroDto)
        {
            var carro = new Carro()
            {
                Id = (int)carroDto.Id,
                Nome = carroDto.Nome,
                KmPorLitro = carroDto.KmPorLitro,
                Cilindros = carroDto.Cilindros,
                Aceleracao = carroDto.Aceleracao,
                Peso = carroDto.Peso,
                Pontencia = carroDto.Pontencia,
                Origem = carroDto.Origem,
                MarcaId = carroDto.MarcaId,
                DataCadastro = carroDto.DataCadastro

            };
            return carro;

        }

        public CarroDto MapperEntityToDto(Carro carro)
        {
            var carroDto = new CarroDto()
            {
                Id = (int)carro.Id,
                Nome = carro.Nome,
                KmPorLitro = carro.KmPorLitro,
                Cilindros = carro.Cilindros,
                Aceleracao = carro.Aceleracao,
                Peso = carro.Peso,
                Pontencia = carro.Pontencia,
                Origem = carro.Origem,
                MarcaId = carro.MarcaId,
                DataCadastro = carro.DataCadastro

            };
            return carroDto;
        }

        public IEnumerable<CarroDto> MapperListCarroDto(IEnumerable<Carro> carros)
        {
            var dto = carros.Select(c => new CarroDto
            {
                Id = c.Id,
                Nome = c.Nome,
                KmPorLitro = c.KmPorLitro,
                Cilindros = c.Cilindros,
                Aceleracao = c.Aceleracao,
                Peso = c.Peso,
                Pontencia = c.Pontencia,
                Origem = c.Origem,
                MarcaId = c.MarcaId,
                DataCadastro = c.DataCadastro
            });
            return dto;
        }
    }
}
