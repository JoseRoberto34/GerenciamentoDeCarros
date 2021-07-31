using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciamento.Servicos.API.Controllers
{

    [Route("controller")]
    [ApiController]
    public class CarroController : ControllerBase
    {

        private readonly IAppCarro _appCarro;


        public CarroController(IAppCarro ServicoAppCarro)
        {
            _appCarro = ServicoAppCarro;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Listar()
        {
            return Ok(_appCarro.Listar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorId(int id)
        {
            return Ok(_appCarro.BuscarPorId(id));
        } 

        // GET api/values/5
        [HttpGet("{nome}")]
        public ActionResult<string> BuscarPorNome(string nome)
        {
            return Ok(_appCarro.BuscarPorNome(nome));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Incluir([FromBody] CarroDto carroDto)
        {
            try
            {
                if (carroDto == null)
                    return NotFound();

                _appCarro.Incluir(carroDto);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Alterar([FromBody] CarroDto carroDto)
        {
            try
            {
                if (carroDto == null)
                    return NotFound();

                _appCarro.Alterar(carroDto);
                return Ok("Carro Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Excluir([FromBody] CarroDto carroDto)
        {
            try
            {
                if (carroDto == null)
                    return NotFound();

                _appCarro.Excluir(carroDto);
                return Ok("Carro Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

