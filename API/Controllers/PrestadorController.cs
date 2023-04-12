using AutoMapper;
using GisaApiArq.API;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using SafAPI.DTO;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("prestador")]
    public class PrestadorController : ControladorCrudBase<Prestador, PrestadorDTO>
    {
        public PrestadorController(ILogger<PrestadorController> logger, IServicoCrudBase<Prestador> servico, IMapper mapper) : base(logger, servico, mapper)
        {
        }
    }
}
