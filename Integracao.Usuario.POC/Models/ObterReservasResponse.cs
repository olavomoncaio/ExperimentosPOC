using System;
using System.Collections.Generic;

namespace Integracao.Usuario.POC.Models
{
    public class ObterReservasResponse : BaseResponse
    {
        public Hospede Hospede { get; set; }
        public List<Reserva> Reservas { get; set; }
    }
}
