using CalculaJuros.Application.DTOs;
using CalculaJuros.Domain.Services;

namespace CalculaJuros.Application.Services;

    public class CalculoJurosAppService
    {
        private readonly ICalculoJurosService _service;

        public CalculoJurosAppService(ICalculoJurosService service)
        {
            _service = service;
        }

        public CalculoJurosResponse Calcular(CalculoJurosRequest request)
        {
            var resultado = _service.Calcular(request.Valor, request.DataVencimento);

            return new CalculoJurosResponse
            {
                ValorOriginal = resultado.ValorOriginal,
                Multa = resultado.Multa,
                Juros = resultado.Juros,
                ValorFinal = resultado.ValorFinal,
                DiasAtraso = resultado.DiasAtraso
            };
        }
    }

