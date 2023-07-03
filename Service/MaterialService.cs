using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Data.Models;
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

        public async Task<AddEditMaterialViewModel?> GetMaterialForEditAsync(int id)
        {
            return await context.Materials
                .Where(m => m.Id == id)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefaultAsync();
        }

        public async Task<bool> EditMaterialAsync(AddEditMaterialViewModel model, int id)
        {
            var material = await context.Materials.FindAsync(id);

            try
            {
                model.Price = model.Price.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Price = model.Price.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                material.Price = Convert.ToDecimal(model.Price);
                material.Name = model.Name;
                material.ANPF = model.ANPF;
                material.ImageUrl = model.ImageUrl;

                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> AddMaterialAsync(AddEditMaterialViewModel model)
        {
            Material material = new Material();

            try
            {
                model.Price = model.Price.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Price = model.Price.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                material.Price = Convert.ToDecimal(model.Price);
                material.Name = model.Name;
                material.ANPF = model.ANPF;
                material.ImageUrl = model.ImageUrl;

                await context.Materials.AddAsync(material);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task DeleteMaterialAsync(int id)
        {
            var material = await context.Materials.FindAsync(id);

            if (material != null)
                context.Materials.Remove(material);

            await context.SaveChangesAsync();
        }
    }    
}