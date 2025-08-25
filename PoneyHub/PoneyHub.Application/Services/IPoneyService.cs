using PoneyHub.Application.Models;

namespace PoneyHub.Application.Services
{
    public interface IPoneyService
    {
        Task<int> InsertAsync(InsertUpdatePoney insertPoney);

        Task UpdateAsync(int id, InsertUpdatePoney updatePoney);

        Task DeleteAsync(int id);

        Task<GetPoney> GetAsync(int id);

        Task<List<GetPoney>> GetAllAsync(string? order);

        Task<PaginatedResults<GetPoney>> GetAllAsync(int skip, int take, string? order);
    }
}