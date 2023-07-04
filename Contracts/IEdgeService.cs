using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IEdgeService
    {
        Task<List<string>> EditEdgeAsync(AddEditEdgeViewModel model, int id);

        Task<IEnumerable<AllEdgesViewModel>> GetAllEdgesAsync();

        Task<AddEditEdgeViewModel> GetEdgeForEditAsync(int id);
    }
}