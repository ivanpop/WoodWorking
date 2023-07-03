using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IEdgeService
    {
        Task<IEnumerable<AllEdgesViewModel>> GetAllEdgesAsync();
        Task<AddEditEdgeViewModel> GetEdgeForEditAsync(int id);
    }
}