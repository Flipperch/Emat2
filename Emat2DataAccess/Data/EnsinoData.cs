using Emat2DataAccess.DbAccess;
using Emat2DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emat2DataAccess.Data;

public class EnsinoData : IEnsinoData
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public EnsinoData(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }

    public Task<IEnumerable<EnsinoModel>> GetEnsinos() =>
        _sqlDataAccess.LoadData<EnsinoModel, dynamic>(storedProcedure: "dbo.spEnsino_GetAll", new { });

    public async Task<EnsinoModel?> GetEnsino(int id)
    {
        var results = await _sqlDataAccess.LoadData<EnsinoModel, dynamic>(
            "dbo.spEnsino_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertEnsino(EnsinoModel ensino) =>
        _sqlDataAccess.SaveData("dbo.spEnsino_Insert", new { ensino.EnsinoNome });

    public Task UpdateEnsino(EnsinoModel ensino) =>
        _sqlDataAccess.SaveData("dbo.spEnsino_Update", ensino);

    public Task DeleteEnsino(int id) =>
        _sqlDataAccess.SaveData("dbo.spEnsino_Delete", new { Id = id });
}
