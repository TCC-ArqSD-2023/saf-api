using GisaDominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Contextos.DbMap
{
    public class PlanoDbMap
    {
        public PlanoDbMap(EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
