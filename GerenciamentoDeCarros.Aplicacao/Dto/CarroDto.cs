using System;

namespace GerenciamentoDeCarros.Aplicacao.Dto
{
    public class CarroDto : BaseDto
    {
        public string Nome { get; set; }
        public int KmPorLitro { get; set; }
        public int Cilindros { get; set; }
        public int Pontencia { get; set; }
        public int Peso { get; set; }
        public int Aceleracao { get; set; }
        public string Origem { get; set; }
        public int MarcaId { get; set; }
        public DateTime DataCadastro { get; set; }

    }
    
}
