using GisaDominio.Entidades;
using GisaDominio.Interfaces.Repositorios;
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
