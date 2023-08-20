using FinancasPessoaisAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancasPessoaisAPI.Infrastructure.Data
{
    public class Context : DbContext
    {
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            {
                modelBuilder.Entity<Despesa>()
                    .Property(d => d.Valor)
                    .HasColumnType("decimal(18, 2)");

                modelBuilder.Entity<Receita>()
                    .Property(r => r.Valor)
                    .HasColumnType("decimal(18, 2)");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Finance;User ID=sa;Password=1b2m3b4m@#$;TrustServerCertificate=true",
                b => b.MigrationsAssembly("FinancasPessoaisAPI.Services"));
            }
        }

    }
}