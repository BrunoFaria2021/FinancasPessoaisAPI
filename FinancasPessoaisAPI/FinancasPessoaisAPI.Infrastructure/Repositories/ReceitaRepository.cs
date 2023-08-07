using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;
using FinancasPessoaisAPI.Domain.Entities;
using FinancasPessoaisAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FinancasPessoaisAPI.Infrastructure.Repositories
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly Context _context;

        public ReceitaRepository(Context context)
        {
            _context = context;
        }

        public Receita ObterPorId(int id)
        {
            return _context.Receitas.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Receita> ObterTodas()
        {
            return _context.Receitas.ToList();
        }

        public void Adicionar(Receita receita)
        {
            _context.Receitas.Add(receita);
            _context.SaveChanges();
        }

        public void Atualizar(Receita receita)
        {
            _context.Entry(receita).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remover(Receita receita)
        {
            _context.Receitas.Remove(receita);
            _context.SaveChanges();
        }
    }
}
