﻿using System;

namespace Integracao.Usuario.POC.Models
{
    public class Acompanhante
    {
        public Guid ReservaId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
