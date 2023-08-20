namespace FinancasPessoaisAPI.Domain.Entities
{
    public class Receita
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public void Inicializar(string descricao, decimal valor, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }

        public void Atualizar(string novaDescricao, decimal novoValor, DateTime novaData)
        {
            Descricao = novaDescricao;
            Valor = novoValor;
            Data = novaData;
        }
    }
}



