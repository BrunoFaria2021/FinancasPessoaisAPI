using FinancasPessoaisAPI.Application.DTOs;
using FinancasPessoaisAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinancasPessoaisAPI.Services.Controllers
{
    [ApiController]
    [Route("api/receitas")]
    public class ReceitaController : ControllerBase
    {
        private readonly IManterReceitaService _receitaService;

        public ReceitaController(IManterReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var receita = _receitaService.ObterReceitaPorId(id);
            if (receita == null)
            {
                return NotFound("Receita não encontrada.");
            }

            return Ok(receita);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var receitas = _receitaService.ObterTodasReceitas();
            return Ok(receitas);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ReceitaDTO receitaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = _receitaService.CriarReceita(receitaDTO);
            return CreatedAtAction(nameof(Get), new { id = id }, new { Message = "Receita criada com sucesso!" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ReceitaDTO receitaDTO)
        {
            var existingReceita = _receitaService.ObterReceitaPorId(id);
            if (existingReceita == null)
            {
                return NotFound("Receita não encontrada com o ID fornecido.");
            }

            _receitaService.AtualizarReceita(receitaDTO);
            return Ok("Receita atualizada com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingReceita = _receitaService.ObterReceitaPorId(id);
            if (existingReceita == null)
            {
                return NotFound();
            }

            _receitaService.ExcluirReceita(id);
            return Ok("Receita excluída com sucesso!");
        }
    }
}