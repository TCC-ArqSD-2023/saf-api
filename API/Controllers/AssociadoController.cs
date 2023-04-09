using GisaApiArq.API;
using GisaApiArq.Infra;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("associado")]
    public class AssociadoController : ControladorCrudBase<Associado>
    {
        public AssociadoController(IRepositorioCrudBase<Associado> repositorio, ILogger<AssociadoController> logger) : base(repositorio, logger)
        {
        }
    }
}
