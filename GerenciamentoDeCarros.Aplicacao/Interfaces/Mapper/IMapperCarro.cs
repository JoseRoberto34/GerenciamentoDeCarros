using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
namespace GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper
{
    public interface IMapperCarro
    {
        Carro MapperDtoToEntity(CarroDto carroDto);
        IEnumerable<CarroDto> MapperListCarroDto(IEnumerable<Carro> carros);
        CarroDto MapperEntityToDto(Carro carro);
       
    }
}
