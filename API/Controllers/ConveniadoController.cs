using AutoMapper;
using GisaApiArq.API;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("conveniado")]
    public class ConveniadoController : ControladorCrudBase<Conveniado, Conveniado>
    {
        public ConveniadoController(ILogger<ConveniadoController> logger, IServicoCrudBase<Conveniado> servico, IMapper mapper) : base(logger, servico, mapper)
        {
        }
    }
}
