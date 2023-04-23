using AutoMapper;
using GisaApiArq.API;
using GisaApiArq.Infra;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using GisaDominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;
using SafAPI.DTO;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("associado")]
    public class AssociadoController : ControladorCrudBase<Associado, Associado>
    {
        protected new readonly IAssociadoServico _servico;

        public AssociadoController(ILogger<AssociadoController> logger, IAssociadoServico servico, IMapper mapper) : base(logger, servico, mapper)
        {
            _servico = servico;
        }

        [HttpPost("aderirPlano")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(List<FluentResults.Error>), StatusCodes.Status500InternalServerError)]
        public virtual IActionResult AderirPlano([FromBody] AderirPlanoDTO dto)
        {
            _logger.LogInformation($"Acionado recurso {nameof(AderirPlano)}.");
            var resultado = _servico.AderirPlano(dto.AssociadoId, dto.PlanoId);

            if (resultado.IsFailed)
                return retornarErroGenerico(resultado.Errors);

            return NoContent();
        }
    }
}
