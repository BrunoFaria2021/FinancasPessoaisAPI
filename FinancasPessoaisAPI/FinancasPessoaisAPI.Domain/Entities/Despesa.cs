using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisAPI.Domain.Entities
{
    public class Despesa
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Despesa(string descricao, decimal valor, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }
    }
}
