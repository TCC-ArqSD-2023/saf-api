using AutoMapper;
using GisaDominio.Entidades;
using SafAPI.DTO;
using System;

namespace SafAPI.Profiles
{
    public class SafProfile : Profile
    {
        public SafProfile()
        {
            CreateMap<Associado, Associado>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));
            CreateMap<Conveniado, Conveniado>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));
            CreateMap<Endereco, Endereco>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));
            CreateMap<Especialidade, Especialidade>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));
            CreateMap<Plano, Plano>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));
            CreateMap<Prestador, Prestador>()
                .ForAllMembers(o => o.Condition((source, destination, member) => member != null));

            CreateMap<PrestadorDTO, Prestador>()
                .ReverseMap()
                .ForMember(p => p.EspecialidadeNome, opt => opt.MapFrom(p => p.Especialidade.Nome));
        }
    }
}
