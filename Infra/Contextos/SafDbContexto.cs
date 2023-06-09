﻿using GisaDominio.Entidades;
using Infra.Contextos.DbMap;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Contextos
{
    public class SafDbContexto : DbContext
    {
        public SafDbContexto(DbContextOptions<SafDbContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("saf");

            new AssociadoDbMap(modelBuilder.Entity<Associado>());
            new ConveniadoDbMap(modelBuilder.Entity<Conveniado>());
            new EnderecoDbMap(modelBuilder.Entity<Endereco>());
            new EspecialidadeDbMap(modelBuilder.Entity<Especialidade>());
            new PlanoDbMap(modelBuilder.Entity<Plano>());
            new PrestadorDbMap(modelBuilder.Entity<Prestador>());
        }
    }
}
