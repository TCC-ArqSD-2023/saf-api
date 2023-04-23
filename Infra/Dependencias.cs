using GisaApiArq.Infra;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using Infra.Contextos;
using Infra.Repositorios;
using Microsoft.Data.SqlClient;
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
            var connString = configuration["ConnectionStrings:SafDbSqlServer"];
            connString += configuration["DbSenha"];

            Console.WriteLine(connString);

            services.AddDbContext<SafDbContexto>(options =>
                options
                //.UseLazyLoadingProxies()
                .UseSqlServer(connString)
            );
            services.AddScoped(typeof(IRepositorioCrudBase<Prestador>), typeof(PrestadorRepositorio));
            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddScoped(typeof(IRepositorioCrudBase<>), typeof(RepositorioCrudBase<>));
            services.AddScoped<DbContext, SafDbContexto>();
        }
    }
}
