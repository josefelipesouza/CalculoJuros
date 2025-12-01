namespace CalculaJuros.Application.DTOs
{
    public class CalculoJurosRequest
    {
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
