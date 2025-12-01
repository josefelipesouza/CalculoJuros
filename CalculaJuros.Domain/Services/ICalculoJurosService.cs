using CalculaJuros.Domain.Entities;

namespace CalculaJuros.Domain.Services;

    public interface ICalculoJurosService
    {
        CalculoJurosResultado Calcular(decimal valor, DateTime dataVencimento);
    }

