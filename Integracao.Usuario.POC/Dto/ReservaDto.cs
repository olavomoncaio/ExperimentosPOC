﻿using System;

namespace Integracao.Usuario.POC.Dto
{
    public class ReservaDto
    {
        public Guid ReservaId { get; set; }
        public int HospedeId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool Ativa { get; set; }
    }
}
