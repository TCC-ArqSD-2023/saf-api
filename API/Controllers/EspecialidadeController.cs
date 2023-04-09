using GisaApiArq.API;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("especialidade")]
    public class EspecialidadeController : ControladorCrudBase<Especialidade>
    {
        public EspecialidadeController(ILogger<EspecialidadeController> logger, IServicoCrudBase<Especialidade> servico) : base(logger, servico)
        {
        }
    }
}
