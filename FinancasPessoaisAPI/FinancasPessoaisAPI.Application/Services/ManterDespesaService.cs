using FinancasPessoaisAPI.Application.DTOs;
using FinancasPessoaisAPI.Application.Interfaces;
using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;

namespace FinancasPessoaisAPI.Application.Services
{
    public class ManterDespesaService : IManterDespesaService
    {
        private readonly IDespesaRepository _despesaRepository;

        public ManterDespesaService(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        public void AtualizarDespesa(DespesaDTO despesaDTO)
        {
            throw new NotImplementedException();
        }

        public int CriarDespesa(DespesaDTO despesaDTO)
        {
            throw new NotImplementedException();
        }

        public void ExcluirDespesa(int id)
        {
            throw new NotImplementedException();
        }

        public DespesaDTO ObterDespesaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DespesaDTO> ObterTodasDespesas()
        {
            throw new NotImplementedException();
        }
    }
}