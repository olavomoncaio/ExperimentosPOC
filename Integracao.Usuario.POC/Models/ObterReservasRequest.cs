using System;

namespace Integracao.Usuario.POC.Models
{
    public class ObterReservasRequest
    {
        public string Documento { get; set; }  
        public Guid ReservaId { get; set; } 
    }
}
