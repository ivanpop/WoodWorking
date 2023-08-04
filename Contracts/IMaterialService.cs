using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IMaterialService
    {
        Task<bool> EditMaterialAsync(AddEditMaterialViewModel model, int id);

        Task<IEnumerable<AllMaterialsViewModel>> GetAllMaterialsAsync();

        Task<AddEditMaterialViewModel?> GetMaterialForEditAsync(int id);

        Task<bool> AddMaterialAsync(AddEditMaterialViewModel model);

        Task DeleteMaterialAsync(int id);
    }
}