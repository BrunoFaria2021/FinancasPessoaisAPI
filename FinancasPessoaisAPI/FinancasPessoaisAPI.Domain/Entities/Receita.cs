namespace FinancasPessoaisAPI.Domain.Entities
{
    public class Receita
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Receita(string descricao, decimal valor, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }
    }

}



