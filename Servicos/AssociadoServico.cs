using AutoMapper;
using FluentResults;
using GisaApiArq.Infra;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using GisaDominio.Interfaces.Servicos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
    public class AssociadoServico : ServicoCrudBase<Associado>, IAssociadoServico
    {
        private readonly IServicoCrudBase<Plano> servicoPlano;

        public AssociadoServico(
            ILogger<AssociadoServico> logger,
            IRepositorioCrudBase<Associado> repositorio,
            IMapper mapper,
            IServicoCrudBase<Plano> servicoPlano
            ) : base(logger, repositorio, mapper)
        {
            this.servicoPlano = servicoPlano;
        }

        public Result AderirPlano(long associadoId, long planoId)
        {
            var resultado = servicoPlano.ObterPorId(planoId);
            if (resultado.IsFailed || resultado.Value == null)
                return Result.Fail(resultado.Errors);

            var plano = resultado.Value;

            var resultadoAssociado = ObterPorId(associadoId);
            if (resultadoAssociado.IsFailed || resultadoAssociado.Value == null)
                return Result.Fail(resultadoAssociado.Errors);

            var associado = resultadoAssociado.Value;

            associado.Plano = plano;

            return Atualizar(associadoId, associado);
        }
    }
}
