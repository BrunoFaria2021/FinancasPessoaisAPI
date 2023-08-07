using FinancasPessoaisAPI.Domain.Entities;

namespace FinancasPessoaisAPI.Domain.Core.interfaces.Repository
{
    public interface IDespesaRepository
    {
        Despesa ObterPorId(int id);
        IEnumerable<Despesa> ObterTodas();
        void Adicionar(Despesa despesa);
        void Atualizar(Despesa despesa);
        void Remover(Despesa despesa);
    }
}
