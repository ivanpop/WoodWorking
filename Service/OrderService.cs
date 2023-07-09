using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;

namespace WoodWorking.Service
{
    public class OrderService : IOrderService
    {
        private readonly WoodWorkingDbContext context;

        public OrderService(WoodWorkingDbContext context)
        {
            this.context = context;
        }

        public async Task CreateNewOrderAsync(GetOrderViewModel model)
        {
            await Console.Out.WriteLineAsync();
        }
    }
}