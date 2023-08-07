using FinancasPessoaisAPI.Domain.Entities;

namespace FinancasPessoaisAPI.Domain.Core.interfaces.Repository
{
    public interface IReceitaRepository
    {
        Receita ObterPorId(int id);
        IEnumerable<Receita> ObterTodas();
        void Adicionar(Receita receita);
        void Atualizar(Receita receita);
        void Remover(Receita receita);
    }
}
