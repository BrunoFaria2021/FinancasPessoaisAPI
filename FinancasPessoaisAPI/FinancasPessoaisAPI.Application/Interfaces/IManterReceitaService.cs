using FinancasPessoaisAPI.Application.DTOs;

namespace FinancasPessoaisAPI.Application.Interfaces
{
    public interface IManterReceitaService
    {
        ReceitaDTO ObterReceitaPorId(int id);
        IEnumerable<ReceitaDTO> ObterTodasReceitas();
        int CriarReceita(ReceitaDTO receitaDTO);
        void AtualizarReceita(ReceitaDTO receitaDTO);
        void ExcluirReceita(int id);
    }
}