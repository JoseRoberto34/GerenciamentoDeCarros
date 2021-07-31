using GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios;
using GerenciamentoDeCarros.Dominio.Core.Interfaces.Serviços;
using System.Collections.Generic;

namespace GerenciamentoDeCarros.Serviços
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : class
    { 
        protected readonly IRepositorioBase<TEntidade> repositorio;
        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }
        public void Incluir(TEntidade entidade)
        {
            repositorio.Incluir(entidade);
        }
        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }
        public IEnumerable<TEntidade> Listar()
        {
            return repositorio.Listar();
        }
        public TEntidade BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }
        public TEntidade BuscarPorNome(string Nome)
        {
            return repositorio.BuscarPorNome(Nome);
        }
        public void Excluir(TEntidade entidade)
        {
            repositorio.Excluir(entidade);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }

    }
}

