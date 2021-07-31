using System.Collections.Generic;

namespace GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade>
        where TEntidade : class
    {
        void Incluir(TEntidade entidade);
        IEnumerable<TEntidade> Listar();
        TEntidade BuscarPorId(int id);
        TEntidade BuscarPorNome(string nome);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void Excluir(int id);
    }
}
