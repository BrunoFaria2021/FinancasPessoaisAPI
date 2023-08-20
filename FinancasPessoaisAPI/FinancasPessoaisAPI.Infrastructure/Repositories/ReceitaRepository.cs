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
            int maxRetryAttempts = 3;
            int retryAttempt = 0;

            while (retryAttempt < maxRetryAttempts)
            {
                try
                {
                    _context.Entry(receita).State = EntityState.Modified;
                    _context.SaveChanges();
                    return; // Sai do método após a atualização bem-sucedida
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var entry = ex.Entries.Single();
                    var databaseValues = entry.GetDatabaseValues();

                    if (databaseValues == null)
                    {
                        // A entidade foi excluída por outra transação
                        return;
                    }
                    else
                    {
                        // Atualiza a entidade com os valores do banco de dados
                        entry.OriginalValues.SetValues(databaseValues);

                        // Incrementa a tentativa de atualização e aguarda um curto período antes de tentar novamente
                        retryAttempt++;
                        Thread.Sleep(TimeSpan.FromSeconds(1)); // Aguarda 1 segundo antes da próxima tentativa
                    }
                }
            }
        }

        public void Remover(Receita receita)
        {
            _context.Receitas.Remove(receita);
            _context.SaveChanges();
        }
    }
}
