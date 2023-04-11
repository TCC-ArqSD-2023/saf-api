using GisaApiArq.API;
using GisaApiArq.Infra;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("associado")]
    public class AssociadoController : ControladorCrudBase<Associado, Associado>
    {
        public AssociadoController(ILogger<AssociadoController> logger, IServicoCrudBase<Associado> servico) : base(logger, servico)
        {
        }
    }
}
