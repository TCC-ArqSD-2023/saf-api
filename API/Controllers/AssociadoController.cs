using GisaApiArq.API;
using GisaApiArq.Infra;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("associado")]
    public class AssociadoController : ControladorBase<Associado>
    {
        public AssociadoController(IRepositorioBase<Associado> repositorio, ILogger<ControladorBase<Associado>> logger) : base(repositorio, logger)
        {
        }
    }
}
