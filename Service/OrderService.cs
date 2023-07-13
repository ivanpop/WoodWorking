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

        public async Task<IEnumerable<AllEdgesViewModel>> GetSelectedEdgesAsync(string id)
        {
            return await context.IdentityUserEdges
                .Where(ie => ie.UserId == id)
                .Select(ie => new AllEdgesViewModel
                {
                    Id = ie.Edge.Id,
                    Price = ie.Edge.Price,
                    Height = ie.Edge.Height,
                    Length = ie.Edge.Length
                }).ToListAsync();
        }
    }
}