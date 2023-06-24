using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IMaterialService
    {
        Task<IEnumerable<AllMaterialsViewModel>> GetAllMaterialsAsync();
    }
}