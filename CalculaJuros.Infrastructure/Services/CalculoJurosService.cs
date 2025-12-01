using CalculaJuros.Domain.Entities;
using CalculaJuros.Domain.Services;

namespace CalculaJuros.Infrastructure.Services;

    public class CalculoJurosService : ICalculoJurosService
    {
        public CalculoJurosResultado Calcular(decimal valor, DateTime dataVencimento)
        {
            var hoje = DateTime.Now.Date;
            var diasAtraso = (hoje - dataVencimento.Date).Days;

            if (diasAtraso < 0)
                diasAtraso = 0;

            decimal multa = 0.025m;
            decimal juros = valor * 0.025m * diasAtraso;
            decimal total = valor  + juros;

            return new CalculoJurosResultado
            {
                ValorOriginal = valor,
                Multa = multa,
                Juros = juros,
                DiasAtraso = diasAtraso,
                ValorFinal = total
                
            };
        }
    }

