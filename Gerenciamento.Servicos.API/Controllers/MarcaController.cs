using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciamentoDeCarros.Aplicacao.Dto;
using GerenciamentoDeCarros.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace Gerenciamento.Servicos.API.Controllers
{
    [Route("controller")]
    [ApiController]
    public class MarcaController : Controller
    {
        private readonly IAppMarca _appMarca;


        public MarcaController(IAppMarca ServicoAppMarca)
        {
            _appMarca = ServicoAppMarca;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Listar()
        {
            return Ok(_appMarca.Listar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorId(int id)
        {
            return Ok(_appMarca.BuscarPorId(id));
        }

        // GET api/values/5
        [HttpGet("{nome}")]
        public ActionResult<string> BuscarPorNome(string nome)
        {
            return Ok(_appMarca.BuscarPorNome(nome));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Incluir([FromBody] MarcaDto marcaDto)
        {
            try
            {
                if (marcaDto == null)
                    return NotFound();

                _appMarca.Incluir(marcaDto);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Alterar([FromBody] MarcaDto marcaDto)
        {
            try
            {
                if (marcaDto == null)
                    return NotFound();

                _appMarca.Alterar(marcaDto);
                return Ok("Carro Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Excluir([FromBody] MarcaDto marcaDto)
        {
            try
            {
                if (marcaDto == null)
                    return NotFound();

                _appMarca.Excluir(marcaDto);
                return Ok("Carro Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
