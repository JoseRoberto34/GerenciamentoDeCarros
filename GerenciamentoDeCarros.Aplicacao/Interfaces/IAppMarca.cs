using GerenciamentoDeCarros.Aplicacao.Dto;
using System.Collections.Generic;

namespace GerenciamentoDeCarros.Aplicacao.Interfaces
{
    public interface IAppMarca
    {
        void Incluir(MarcaDto entidade);
        IEnumerable<MarcaDto> Listar();
        MarcaDto BuscarPorId(int id);
        MarcaDto BuscarPorNome(string Nome);
        void Alterar(MarcaDto entidade);
        void Excluir(MarcaDto entidade);
      
    }
}
