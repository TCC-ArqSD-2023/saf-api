using AutoMapper;
using GisaApiArq.API;
using GisaApiArq.Infra;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using GisaDominio.Enum;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("plano")]
    public class PlanoController : ControladorCrudBase<Plano, Plano>
    {
        public PlanoController(ILogger<PlanoController> logger, IServicoCrudBase<Plano> servico, IMapper mapper) : base(logger, servico, mapper)
        {
        }
    }
}
