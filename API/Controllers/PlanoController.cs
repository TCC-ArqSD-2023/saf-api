using GisaApiArq.API;
using GisaApiArq.Infra;
using GisaDominio.Entidades;
using GisaDominio.Enum;
using Microsoft.AspNetCore.Mvc;

namespace SafAPI.Controllers
{
    [ApiController]
    [Route("plano")]
    public class PlanoController : ControladorCrudBase<Plano>
    {
        public PlanoController(IRepositorioCrudBase<Plano> repositorio, ILogger<PlanoController> logger) : base(repositorio, logger) { }

        //[HttpGet]
        //public IActionResult NovoPlano()
        //{
        //    var plano = new Plano
        //    {
        //        Nome = "Plano 01",
        //        CodigoAns = "codigo01",
        //        Categoria = CategoriaPlanoEnum.Individual,
        //        Tipo = TipoPlanoEnum.Enfermaria,
        //        Odonto = true,
        //        IdadeMinima = 18,
        //        IdadeMaxima = 90,
        //        QuantidadeConsultasAno = 30,
        //        QuantidadeExamesAno = 50,
        //        ValorMensalidade = 100

        //    };

        //    _repositorio.Inserir(plano);
        //    return Ok();
        //}
    }
}
