using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GisaDominio.Entidades;

namespace Infra.Contextos.DbMap
{
    public class AssociadoDbMap
    {
        public AssociadoDbMap(EntityTypeBuilder<Associado> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
