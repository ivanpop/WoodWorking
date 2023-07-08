using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Data.Models;
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

        public async Task<List<string>> AddEdgeAsync(AddEditEdgeViewModel model)
        {
            Edge edge = new Edge();

            List<string> errorMessages = new List<string>();

            try
            {
                model.Height = model.Height.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Height = model.Height.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                edge.Height = Convert.ToDecimal(model.Height);
            }
            catch (Exception)
            {
                errorMessages.Add("Грешна височина!");
            }

            try
            {
                model.Length = model.Length.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Length = model.Length.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                edge.Length = Convert.ToDecimal(model.Length);
            }
            catch (Exception)
            {
                errorMessages.Add("Грешна широчина!");
            }

            try
            {
                model.Price = model.Price.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                model.Price = model.Price.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                edge.Price = Convert.ToDecimal(model.Price);

                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                errorMessages.Add("Грешна цена!");
            }

            if (errorMessages.Count == 0) 
            {
                await context.Edges.AddAsync(edge);
                await context.SaveChangesAsync();
            }

            return errorMessages;
        }

        public async Task DeleteMaterialAsync(int id)
        {
            var edge = await context.Edges.FindAsync(id);

            if (edge != null)
                context.Edges.Remove(edge);

            await context.SaveChangesAsync();
        }

        public async Task<AddEditEdgeViewModel?> GetEdgeByIdAsync(int id)
        {
            return await context.Edges
                    .Where(e => e.Id == id)
                    .Select(e => new AddEditEdgeViewModel
                    {
                        Id = e.Id,
                        Height = e.Height.ToString(),
                        Length = e.Length.ToString(),
                        Price = e.Price.ToString()
                    }).FirstOrDefaultAsync();
        }

        public async Task<bool> AddEdgeToCollectionAsync(string storeId, AddEditEdgeViewModel edge)
        {
            bool allreadyAdded = await context.identityUserEdges
                            .AnyAsync(ub => ub.StoreId == storeId && ub.EdgeId == edge.Id);

            if (!allreadyAdded)
            {
                var userEdge = new IdentityUserEdge
                {
                    StoreId = storeId,
                    EdgeId = edge.Id
                };

                await context.identityUserEdges.AddAsync(userEdge);
                await context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<IEnumerable<AllEdgesViewModel?>> GetAddedEdges(string userId)
        {
            return await context.identityUserEdges
                .Where(ue => ue.StoreId == userId)
                .Select(edge => new AllEdgesViewModel
                {
                    Id = edge.Edge.Id,
                    Height = edge.Edge.Height,
                    Length = edge.Edge.Length,
                    Price = edge.Edge.Price
                }).ToListAsync();
        }
    }
}