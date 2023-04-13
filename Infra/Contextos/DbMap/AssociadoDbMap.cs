using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GisaDominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contextos.DbMap
{
    public class AssociadoDbMap
    {
        public AssociadoDbMap(EntityTypeBuilder<Associado> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Endereco)
                .WithMany()
                .HasForeignKey(a => a.EnderecoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Plano)
                .WithMany()
                .HasForeignKey(a => a.PlanoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
