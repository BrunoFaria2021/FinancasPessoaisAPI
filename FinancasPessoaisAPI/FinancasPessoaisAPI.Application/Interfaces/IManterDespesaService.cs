using FinancasPessoaisAPI.Application.DTOs;

namespace FinancasPessoaisAPI.Application.Interfaces
{
    public interface IManterDespesaService
    {
        DespesaDTO ObterDespesaPorId(int id);
        IEnumerable<DespesaDTO> ObterTodasDespesas();
        int CriarDespesa(DespesaDTO despesaDTO);
        void AtualizarDespesa(DespesaDTO despesaDTO);
        void ExcluirDespesa(int id);
    }
}