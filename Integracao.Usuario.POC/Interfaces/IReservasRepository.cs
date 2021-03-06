﻿using Integracao.Usuario.POC.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Interfaces
{
    public interface IReservasRepository
    {
        Task<IEnumerable<ReservaDto>> ObterReservas(int hospedeId, bool inativa);
    }
}
