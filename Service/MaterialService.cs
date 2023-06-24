using Microsoft.EntityFrameworkCore;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;

namespace WoodWorking.Service
{
    public class MaterialService : IMaterialService
    {
        private readonly WoodWorkingDbContext context;

        public MaterialService(WoodWorkingDbContext context) 
        {
                this.context = context;
        }

        public async Task<IEnumerable<AllMaterialsViewModel>> GetAllMaterialsAsync()
        {
            return await context.Materials
                .Select(m => new AllMaterialsViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    Price = m.Price,
                    ImageUrl = m.ImageUrl,

                }).ToListAsync();
        }
    }
}