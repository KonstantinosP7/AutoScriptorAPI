using AutoPrescriptor.Domain.Models;
using AutoScriptor.Infrastructure.Interface;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace AutoScriptor.Infrastructure.Service;

public  class DBHandler : IDBHandler
{
    private readonly CommunicationSettings _connectionStringSettings;
    public DBHandler(IOptions<CommunicationSettings> connectionStringSettings)
    {
        _connectionStringSettings = connectionStringSettings.Value;
    }

    public async Task<IEnumerable<BreathDevice>> RetrieveBreathDevices()
    {
        string storedProcedureName = "SELECT [Id], [eDapiCode], [ekapty], [description], [Price], [SerialNumber], [IsActive] FROM BreathDevices";

        try
        {
            using var connection = new SqlConnection(_connectionStringSettings.dbconnection);
            var resultList = await connection.QueryAsync<BreathDevice>(
                    storedProcedureName,
                    commandType: CommandType.Text
                ).ConfigureAwait(false);

            return resultList;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<BreathDevice>();
        }
    }

    public async Task InsertNewPrescription(NewPrescription newPrescription)
    {
        string storedProcedureName = "INSERT INTO [dbo].[NewPrescriptions]([ExecutionDate], [PrescriptionData]) " +
            $"VALUES ( '{newPrescription.ExecutionDate}' , N'{newPrescription.PrescriptionData}')";

        try
        {
            using var connection = new SqlConnection(_connectionStringSettings.dbconnection);
            var resultList = await connection.ExecuteAsync(
                    storedProcedureName,
                    commandType: CommandType.Text
                ).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            return;
        }
    }

    public async Task<IEnumerable<NewPrescription>> RetrieveDailyPrescriptions(DateTime date)
    {
        string storedProcedureName = "SELECT [Id], [ExecutionDate], [PrescriptionData] FROM [NewPrescriptions] " +
            $"WHERE ExecutionDate = '{date.ToString("yyyy-MM-dd")}'";

        try
        {
            using var connection = new SqlConnection(_connectionStringSettings.dbconnection);
            var resultList = await connection.QueryAsync<NewPrescription>(
                    storedProcedureName,
                    commandType: CommandType.Text
                ).ConfigureAwait(false);

            return resultList;
        }
        catch (Exception ex)
        {
            return Enumerable.Empty<NewPrescription>();
        }
    }
}
