using Microsoft.EntityFrameworkCore;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;

namespace WoodWorking.Service
{
    public class EdgeService : IEdgeService
    {
        private readonly WoodWorkingDbContext context;

        public EdgeService(WoodWorkingDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AllEdgesViewModel>> GetAllEdgesAsync()
        {
            return await context.Edges
                .Select(e => new AllEdgesViewModel
                {
                    Id = e.Id,
                    Length = e.Length,
                    Height = e.Height,
                    Price = e.Price
                }).ToListAsync();
        }
    }
}