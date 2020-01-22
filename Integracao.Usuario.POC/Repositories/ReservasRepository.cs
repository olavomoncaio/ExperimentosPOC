using Dapper;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Repositories
{
    public sealed class ReservasRepository : RepositoryBase, IReservasRepository
    {
        public ReservasRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<ReservaDto>> ObterReservas(int hospedeId, bool inativa)
        {
            string query = @"SELECT   Reserva.ReservaId, Reserva.DataEntrada, Reserva.DataSaida, Reserva.Ativa                          
                             FROM Reserva(NOLOCK)
                             INNER JOIN Hospede(NOLOCK) ON Hospede.HospedeId = Reserva.HospedeId
                             AND Reserva.HospedeId = @hospedeId";

            if (!inativa)
                query += " AND Reserva.Ativa = 1";

            using (var con = new SqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                return await con.QueryAsync<ReservaDto>(query, new { hospedeId } );
            }
        }
    }
}
