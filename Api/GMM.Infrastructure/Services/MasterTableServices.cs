using GMM.Application.Interfaces.Services;
using GMM.Application.Models;
using GMM.Common.Helpers;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Infrastructure.Services
{
    public class MasterTableServices : IMasterTableServices
    {
        private readonly IConfiguration _configuration;
        public MasterTableServices(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public async Task<DataTable> FindAllByStoreProcedure(CancellationToken cancellationToken = default)
        {
            using var con = new SqlConnection(_configuration.GetConnectionString("DEV_STANDAR"));
            await con.OpenAsync();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "Cnfg.USP_LIST_MasterTableAll";
            cmd.CommandType = CommandType.StoredProcedure;
            using var reader = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            var dt = new DataTable();
            dt.Load(reader);
            await con.CloseAsync();
            return dt;
        }

        public IEnumerable<ModelMasterTable> ListMasterTable(ModelMasterTable masterTableFilterRequest)
        {
            IEnumerable<ModelMasterTable> response;

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DEV_STANDAR")))
            {
   
                var parameters = new DynamicParameters();
                parameters.Add("@ParamIIdMasterTableParentReport", masterTableFilterRequest.IdMasterTable);

                var resultResponse = connection.QueryAsync<ModelMasterTable>(
                    sql: $"{ConstantMasterTable.Schema.Cnfg}.{ConstantMasterTable.Procedure.ListMasterTable}",
                    param: parameters,
                    commandType: CommandType.StoredProcedure).Result;

                response = resultResponse;
            }

            return response;
        }

    }

}
