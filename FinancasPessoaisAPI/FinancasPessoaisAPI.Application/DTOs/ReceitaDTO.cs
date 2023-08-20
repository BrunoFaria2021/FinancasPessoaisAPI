namespace FinancasPessoaisAPI.Application.DTOs
{
    public class ReceitaDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
