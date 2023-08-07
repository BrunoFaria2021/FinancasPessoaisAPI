using FinancasPessoaisAPI.Application.DTOs;
using FinancasPessoaisAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinancasPessoaisAPI.Services.Controllers
{
    [ApiController]
    [Route("api/despesas")]
    public class DespesaController : ControllerBase
    {
        private readonly IManterDespesaService _despesaService;

        public DespesaController(IManterDespesaService despesaService)
        {
            _despesaService = despesaService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var despesa = _despesaService.ObterDespesaPorId(id);
            if (despesa == null)
            {
                return NotFound();
            }

            return Ok(despesa);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var despesas = _despesaService.ObterTodasDespesas();
            return Ok(despesas);
        }

        [HttpPost]
        public IActionResult Create(DespesaDTO despesaDTO)
        {
            var id = _despesaService.CriarDespesa(despesaDTO);
            return CreatedAtAction(nameof(Get), new { id = id }, despesaDTO);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, DespesaDTO despesaDTO)
        {
            var existingDespesa = _despesaService.ObterDespesaPorId(id);
            if (existingDespesa == null)
            {
                return NotFound();
            }

            _despesaService.AtualizarDespesa(despesaDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingDespesa = _despesaService.ObterDespesaPorId(id);
            if (existingDespesa == null)
            {
                return NotFound();
            }

            _despesaService.ExcluirDespesa(id);
            return NoContent();
        }
    }
}