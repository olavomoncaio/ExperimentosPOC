using System;
using System.Collections.Generic;

namespace Integracao.Usuario.POC.Models
{
    public class ObterReservasResponse : BaseResponse
    {
        public Guid ReservaId { get; set; }
        public Hospede Hospede { get; set; }
        public List<Acompanhante> Acompanhantes { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
    }
}
