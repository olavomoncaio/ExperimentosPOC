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

        public async Task<IEnumerable<AcompanhanteDto>> ObterAcompanhantes(Guid reservaId)
        {
            string query = @"SELECT  Documento, Nome, Sobrenome, DataNascimento
                            FROM Acompanhante
                            WHERE ReservaId = @reservaId";

            using (var con = new SqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                return await con.QueryAsync<AcompanhanteDto>(query, new { reservaId });
            }
        }
    }
}
