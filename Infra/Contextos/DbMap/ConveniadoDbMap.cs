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
    public class ConveniadoDbMap
    {
        public ConveniadoDbMap(EntityTypeBuilder<Conveniado> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Endereco)
                .WithMany()
                .HasForeignKey(c => c.EnderecoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
