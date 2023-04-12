using AutoMapper;
using GisaApiArq.Infra;
using GisaDominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class PrestadorRepositorio : RepositorioCrudBase<Prestador>
    {
        public PrestadorRepositorio(DbContext contexto, ILogger<RepositorioBase<Prestador>> logger, IMapper mapper) : base(contexto, logger, mapper)
        {
        }

        public override IEnumerable<Prestador> ObterTodos()
        {
            return _colecao
                .Include(p => p.Especialidade)
                .Include(p => p.EnderecoAtendimento)
                .AsEnumerable();
        }

        public override Prestador? ObterPorId(long id)
        {
            return _colecao
                .Include(p => p.Especialidade)
                .Include(p => p.EnderecoAtendimento)
                .SingleOrDefault(e => e.Id == id);
        }
    }
}
