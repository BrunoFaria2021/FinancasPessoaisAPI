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
                return NotFound();
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
        public IActionResult Create(ReceitaDTO receitaDTO)
        {
            var id = _receitaService.CriarReceita(receitaDTO);
            return CreatedAtAction(nameof(Get), new { id = id }, receitaDTO);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ReceitaDTO receitaDTO)
        {
            var existingReceita = _receitaService.ObterReceitaPorId(id);
            if (existingReceita == null)
            {
                return NotFound();
            }

            _receitaService.AtualizarReceita(receitaDTO);
            return NoContent();
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
            return NoContent();
        }
    }
}