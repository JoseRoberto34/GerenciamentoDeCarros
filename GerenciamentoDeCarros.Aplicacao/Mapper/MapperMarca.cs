using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Aplicacao.Interfaces.Mapper;
using GerenciamentoDeCarros.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
namespace GerenciamentoDeCarros.Aplicacao.Mapper
{
    public class MapperMarca : IMapperMarca
    {
        public Marca MapperDtoToEntity(MarcaDto marcaDto)
        {
            var marca = new Marca()
            {
                Id = (int)marcaDto.Id,
                Nome = marcaDto.Nome,
                OrigemMarca = marcaDto.OrigemMarca

            };
            return marca;
        }

        public MarcaDto MapperEntityToDto(Marca marca)
        {
            var marcaDto = new MarcaDto()
            {
                Id = (int)marca.Id,
                Nome = marca.Nome,
                OrigemMarca = marca.OrigemMarca

            };
            return marcaDto;
        }

        public IEnumerable<MarcaDto> MapperListMarcaDto(IEnumerable<Marca> marcas)
        {
            var dto = marcas.Select(m => new MarcaDto
            {
                Id = m.Id,
                Nome = m.Nome,
                OrigemMarca = m.OrigemMarca

            });
            return dto;
        }
    }
}
