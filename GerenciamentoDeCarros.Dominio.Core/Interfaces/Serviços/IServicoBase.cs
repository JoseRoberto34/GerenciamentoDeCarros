using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços
{
    public interface IServicoBase<TEntidade>
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
