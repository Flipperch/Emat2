using Emat2DataAccess.Models;

namespace Emat2DataAccess.Data
{
    public interface IEnsinoData
    {
        Task DeleteEnsino(int id);
        Task<EnsinoModel?> GetEnsino(int id);
        Task<IEnumerable<EnsinoModel>> GetEnsinos();
        Task InsertEnsino(EnsinoModel ensino);
        Task UpdateEnsino(EnsinoModel ensino);
    }
}