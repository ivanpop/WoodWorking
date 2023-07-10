using Microsoft.EntityFrameworkCore;
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

        public async Task CreateNewOrderAsync(OrderViewModel model)
        {
            await Console.Out.WriteLineAsync();
        }

        public async Task<IEnumerable<AllMaterialsViewModel>> AllMaterialsAsync()
        {
            return await context
                .Materials
                .Select(m => new AllMaterialsViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Price = m.Price
                }).ToListAsync();
        }
    }
}