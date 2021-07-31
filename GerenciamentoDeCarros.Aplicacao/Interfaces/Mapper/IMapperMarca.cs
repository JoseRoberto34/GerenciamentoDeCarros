using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
namespace GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper
{
    public interface IMapperMarca
    {
        Marca MapperDtoToEntity(MarcaDto marcaDto);
        IEnumerable<MarcaDto> MapperListMarcaDto(IEnumerable<Marca> marcas);
        MarcaDto MapperEntityToDto(Marca marca);
    }
}
