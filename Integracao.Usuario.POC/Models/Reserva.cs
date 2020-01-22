using System;
using System.Collections.Generic;

namespace Integracao.Usuario.POC.Models
{
    public class Reserva
    {
        public Guid ReservaId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool Ativa { get; set; }
        public List<Acompanhante> Acompanhantes { get; set; }
    }
}
