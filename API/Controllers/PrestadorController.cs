using GisaApiArq.API;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("prestador")]
    public class PrestadorController : ControladorCrudBase<Prestador, Prestador>
    {
        public PrestadorController(ILogger<PrestadorController> logger, IServicoCrudBase<Prestador> servico) : base(logger, servico)
        {
        }
    }
}
