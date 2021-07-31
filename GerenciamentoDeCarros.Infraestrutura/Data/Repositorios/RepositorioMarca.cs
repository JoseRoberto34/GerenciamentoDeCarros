using GerenciamentoDeCarros.Dominio.Core.Interfaces.Repositorios;
using GerenciamentoDeCarros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeCarros.Infraestrutura.Data.Repositorios
{
    public class RepositorioMarca : RepositorioBase<Marca>, IRepositorioMarca
    {
        private readonly SqlContext _context;

        public RepositorioMarca(SqlContext sqlContext)
            : base(sqlContext)
        {
            _context = sqlContext;
        }
    }
   
}
