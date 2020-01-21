using AutoMapper;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Models;

namespace Integracao.Usuario.POC.Mapper
{
    public class ReservasProfile : Profile
    {
        public ReservasProfile()
        {
            CreateMap<ReservaDto, ObterReservasResponse>()
                .ForMember(dest => dest.Hospede, opt => opt.MapFrom(src => src.Hospede))
                .ForMember(dest => dest.DataEntrada, opt => opt.MapFrom(src => src.DataEntrada))
                .ForMember(dest => dest.DataSaida, opt => opt.MapFrom(src => src.DataSaida))
                .ForMember(dest => dest.ReservaId, opt => opt.MapFrom(src => src.ReservaId));

            CreateMap<AcompanhanteDto, Acompanhante>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.Sobrenome))
                .ForMember(dest => dest.Documento, opt => opt.MapFrom(src => src.Documento))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.DataNascimento));
        }
    }
}
