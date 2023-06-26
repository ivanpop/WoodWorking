using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IMaterialService
    {
        Task<bool> EditBookAsync(EditMaterialViewModel model, int id);
        Task<IEnumerable<AllMaterialsViewModel>> GetAllMaterialsAsync();

        Task<EditMaterialViewModel> GetMaterialForEditAsync(int id);
    }
}