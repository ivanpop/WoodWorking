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
                    Id = m.Id,
                    Name = m.Name,
                    ANPF = m.ANPF,
                    Price = m.Price,
                    ImageUrl = m.ImageUrl,

                }).ToListAsync();
        }

        public async Task<EditMaterialViewModel?> GetMaterialForEditAsync(int id)
        {
            return await context.Materials
                .Where(m => m.Id == id)
                .Select(m => new EditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price,
                }).FirstOrDefaultAsync();
        }

        public async Task EditBookAsync(EditMaterialViewModel model, int id)
        {
            var material = await context.Materials.FindAsync(id);

            if (material != null)
            {
                material.Name = model.Name;
                material.ANPF = model.ANPF;
                material.Price = model.Price;
                material.ImageUrl = model.ImageUrl;

                await context.SaveChangesAsync();
            }
        }
    }
}