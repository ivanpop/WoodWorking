using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IOrderService
    {
        Task CreateNewOrderAsync(OrderViewModel model);

        Task<IEnumerable<AllMaterialsViewModel>> AllMaterialsAsync();

        Task<IEnumerable<AllEdgesViewModel>> GetSelectedEdgesAsync(string id);

        Task <FinishedOrderViewModel> ConvertToFinishedOrder(OrderViewModel model);
    }
}