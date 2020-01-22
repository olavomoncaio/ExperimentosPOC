using AutoMapper;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Models;

namespace Integracao.Usuario.POC.Mapper
{
    public class ReservasProfile : Profile
    {
        public ReservasProfile()
        {
            CreateMap<ReservaDto, Reserva>()
                .ForMember(dest => dest.DataEntrada, opt => opt.MapFrom(src => src.DataEntrada))
                .ForMember(dest => dest.DataSaida, opt => opt.MapFrom(src => src.DataSaida))
                .ForMember(dest => dest.Ativa, opt => opt.MapFrom(src => src.Ativa))
                .ForMember(dest => dest.ReservaId, opt => opt.MapFrom(src => src.ReservaId))
                .ForMember(dest => dest.Acompanhantes, opt => opt.Ignore());

            CreateMap<AcompanhanteDto, Acompanhante>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.Sobrenome))
                .ForMember(dest => dest.Documento, opt => opt.MapFrom(src => src.Documento))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.DataNascimento))
                .ForMember(dest => dest.ReservaId, opt => opt.MapFrom(src => src.ReservaId));

            CreateMap<HospedeDto, Hospede>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Documento, opt => opt.MapFrom(src => src.Documento))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.Sobrenome))
                .ForMember(dest => dest.Documento, opt => opt.MapFrom(src => src.Documento))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.DataNascimento))
                .ForMember(dest => dest.Logradouro, opt => opt.MapFrom(src => src.Logradouro))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
                .ForMember(dest => dest.Complemento, opt => opt.MapFrom(src => src.Complemento))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Cidade))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ForMember(dest => dest.Celular, opt => opt.MapFrom(src => src.Celular))
                .ForMember(dest => dest.DataDeCadastro, opt => opt.MapFrom(src => src.DataDeCadastro));
        }
    }
}
