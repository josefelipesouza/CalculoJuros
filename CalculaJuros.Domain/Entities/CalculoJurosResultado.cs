namespace CalculaJuros.Domain.Entities;

    public class CalculoJurosResultado
    {
        public decimal ValorOriginal { get; set; }
        public decimal Multa { get; set; }
        public decimal Juros { get; set; }
        public decimal ValorFinal { get; set; }
        public int DiasAtraso { get; set; }
    }

