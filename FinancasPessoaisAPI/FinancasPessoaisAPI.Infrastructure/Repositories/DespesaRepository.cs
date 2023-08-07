using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;
using FinancasPessoaisAPI.Domain.Entities;
using FinancasPessoaisAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FinancasPessoaisAPI.Infrastructure.Repositories
{
    public class DespesaRepository : IDespesaRepository
    {
        private readonly Context _context;

        public DespesaRepository(Context context)
        {
            _context = context;
        }

        public Despesa ObterPorId(int id)
        {
            return _context.Despesas.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Despesa> ObterTodas()
        {
            return _context.Despesas.ToList();
        }

        public void Adicionar(Despesa despesa)
        {
            _context.Despesas.Add(despesa);
            _context.SaveChanges();
        }

        public void Atualizar(Despesa despesa)
        {
            _context.Entry(despesa).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remover(Despesa despesa)
        {
            _context.Despesas.Remove(despesa);
            _context.SaveChanges();
        }
    }
}
