﻿using Integracao.Usuario.POC.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Interfaces
{
    public interface IAcompanhantesRepository
    {
        Task<IEnumerable<AcompanhanteDto>> ObterAcompanhantes(Guid reservaId);
    }
}
