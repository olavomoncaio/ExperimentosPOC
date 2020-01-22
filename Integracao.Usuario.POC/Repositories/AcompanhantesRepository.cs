using Dapper;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Repositories
{
    public sealed class AcompanhantesRepository : RepositoryBase, IAcompanhantesRepository
    {
        public AcompanhantesRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<AcompanhanteDto>> ObterAcompanhantes(int hospedeId)
        {
            string query = @"SELECT     Acompanhante.Documento, Acompanhante.Nome, Acompanhante.Sobrenome, 
                                        Acompanhante.DataNascimento, Acompanhante.ReservaID
                            FROM Acompanhante AS Acompanhante 
                            INNER JOIN Reserva AS Reserva on Acompanhante.ReservaID = Reserva.ReservaID
                            INNER JOIN Hospede AS Hospede on Reserva.HospedeID = Hospede.HospedeID
                            WHERE Hospede.HospedeID = @hospedeId";

            using (var con = new SqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                return await con.QueryAsync<AcompanhanteDto>(query, new { hospedeId });
            }
        }
    }
}
