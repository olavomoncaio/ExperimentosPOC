﻿using System;
using System.Collections.Generic;

namespace Integracao.Usuario.POC.Models
{
    public class ObterRespostaResponse
    {
        public Guid ReservaId { get; set; }
        public string Nome { get; set; }
        public List<Hospede> Hospedes { get; set; }
    }
}
