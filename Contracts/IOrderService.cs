using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IOrderService
    {
        Task CreateNewOrderAsync(OrderViewModel model);
    }
}