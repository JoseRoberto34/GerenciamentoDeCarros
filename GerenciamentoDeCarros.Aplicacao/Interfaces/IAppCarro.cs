using GerenciamentoDeCarros.Aplicacao.Dto;
using System.Collections.Generic;

namespace GerenciamentoDeCarros.Aplicacao.Interfaces
{
    public interface IAppCarro
    {
        void Incluir(CarroDto entidade);
        IEnumerable<CarroDto> Listar();
        CarroDto BuscarPorId(int id);
        CarroDto BuscarPorNome(string Nome);
        void Alterar(CarroDto entidade);
        void Excluir(CarroDto entidade);
       
    }
}
