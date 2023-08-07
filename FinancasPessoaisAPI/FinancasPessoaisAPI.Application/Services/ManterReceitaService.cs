using FinancasPessoaisAPI.Application.DTOs;
using FinancasPessoaisAPI.Application.Interfaces;
using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;

namespace FinancasPessoaisAPI.Application.Services
{
    public class ManterReceitaService : IManterReceitaService
    {
        private readonly IReceitaRepository _receitaRepository;

        public ManterReceitaService(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        public void AtualizarReceita(ReceitaDTO receitaDTO)
        {
            throw new NotImplementedException();
        }

        public int CriarReceita(ReceitaDTO receitaDTO)
        {
            throw new NotImplementedException();
        }

        public void ExcluirReceita(int id)
        {
            throw new NotImplementedException();
        }

        public ReceitaDTO ObterReceitaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceitaDTO> ObterTodasReceitas()
        {
            throw new NotImplementedException();
        }
    }
}
