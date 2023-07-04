using Microsoft.EntityFrameworkCore;
using System.Globalization;
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

        public async Task<AddEditEdgeViewModel?> GetEdgeForEditAsync(int id)
        {
            return await context.Edges
                .Where(e => e.Id == id)
                .Select(e => new AddEditEdgeViewModel
                {
                    Height = e.Height.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),

                    Length = e.Length.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),

                    Price = e.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                }).FirstOrDefaultAsync();
        }

        public async Task<List<string>> EditEdgeAsync(AddEditEdgeViewModel model, int id)
        {
            var material = await context.Edges.FindAsync(id);

            List<string> errorMessages = new List<string>();

            try
            {
                model.Height = model.Height.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Height = model.Height.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                material.Height = Convert.ToDecimal(model.Height);
            }
            catch (Exception)
            {

                errorMessages.Add("Грешна височина!");
            }

            try
            {
                model.Length = model.Length.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Length = model.Length.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                material.Length = Convert.ToDecimal(model.Length);
            }
            catch (Exception)
            {
                errorMessages.Add("Грешна широчина!");
            }

            try
            {
                model.Price = model.Price.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Price = model.Price.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                material.Price = Convert.ToDecimal(model.Price);

                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                errorMessages.Add("Грешна цена!");
            }

            return errorMessages;
        }
    }
}