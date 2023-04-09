﻿using GisaApiArq.Infra;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class Dependencias
    {
        public static void ConfigurarServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<SafDbContexto>(options =>
                options.UseNpgsql(configuration["ConnectionStrings:SafDbPostgres"]));
            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddScoped<DbContext, SafDbContexto>();
        }
    }
}