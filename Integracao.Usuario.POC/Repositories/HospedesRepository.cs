using Dapper;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Repositories
{
    public sealed class HospedesRepository : RepositoryBase, IHospedesRepository
    {
        public HospedesRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<HospedeDto> ObterHospede(int hospedeId)
        {
            string query = @"SELECT  Documento, Nome, Sobrenome, DataNascimento, 
                                     Logradouro, Numero, Complemento, Cidade, Estado, Telefone,
                                     Celular, DataDeCadastro, HospedeId
                            FROM Hospede
                            WHERE HospedeId = @hospedeId";

            using (var con = new SqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                return await con.QueryFirstOrDefaultAsync<HospedeDto>(query, new { hospedeId });
            }
        }
    }
}
