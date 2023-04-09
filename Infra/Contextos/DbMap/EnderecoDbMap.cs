using GisaDominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Contextos.DbMap
{
    public class EnderecoDbMap
    {
        public EnderecoDbMap(EntityTypeBuilder<Endereco> builder) 
        { 
            builder.HasKey(e => e.Id);
        }
    }
}
