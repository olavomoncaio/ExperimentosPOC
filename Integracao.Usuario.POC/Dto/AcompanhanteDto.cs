using System;

namespace Integracao.Usuario.POC.Dto
{
    public class AcompanhanteDto
    {
        public int AcompanhanteId { get; set; }
        public Guid ReservaId { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
