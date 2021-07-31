using GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciamentoDeCarros.Infraestrutura.Data.Repositorios
{
    public abstract  class RepositorioBase<TEntidade> :  IRepositorioBase<TEntidade> where TEntidade : class
    {
        private readonly SqlContext _context;

        public RepositorioBase(SqlContext Context)
        {
            _context = Context;
        }
        public void Alterar(TEntidade entidade)
        {
            try
            {
                _context.Entry(entidade).State = EntityState.Modified;
                _context.SendChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(TEntidade entidade)
        {
            try
            {
                _context.Set<TEntidade>().Remove(entidade);
                _context.SendChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Incluir(TEntidade entidade)
        {
            {
                try
                {
                    _context.Set<TEntidade>().Add(entidade);
                    _context.SendChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public TEntidade BuscarPorId(int id)
        {
            return _context.Set<TEntidade>().Find(id);
        }
        public TEntidade BuscarPorNome(string nome)
        {
            return _context.Set<TEntidade>().Find(nome);
        }

        public IEnumerable<TEntidade> Listar()
        {
            return _context.Set<TEntidade>().ToList();
        }
        public void Excluir(int id)
        {
            try
            {
                var entidade = BuscarPorId(id);
                _context.Set<TEntidade>().Remove(entidade);
                _context.SendChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }
    }
    
}

