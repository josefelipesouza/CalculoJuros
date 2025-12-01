using Microsoft.AspNetCore.Mvc;
using CalculaJuros.Application.Services;
using CalculaJuros.Application.DTOs;

namespace CalculaJuros.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class CalculoJurosController : ControllerBase
    {
        private readonly CalculoJurosAppService _appService;

        public CalculoJurosController(CalculoJurosAppService appService)
        {
            _appService = appService;
        }

        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] CalculoJurosRequest request)
        {
            var resultado = _appService.Calcular(request);
            return Ok(resultado);
        }
    }

