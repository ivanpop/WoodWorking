using Library.Services;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Data.Models;
using WoodWorking.Models;

namespace WoodWorking.Service
{
    public class OrderService : IOrderService
    {
        private readonly WoodWorkingDbContext context;
        private readonly IUserService userService;

        public OrderService(WoodWorkingDbContext context, IUserService userService)
        {
            this.context = context;
            this.userService = userService;
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

        public async Task<FinishedOrderViewModel> ConvertToFinishedOrder(OrderViewModel model)
        {
            FinishedOrderViewModel finishedOrder = new FinishedOrderViewModel();
            finishedOrder.OrderedMaterials = model.OrderedMaterials;

            finishedOrder.ClientName = model.ClientName;
            finishedOrder.ClientPhone = model.ClientPhone;
            finishedOrder.CreatedDate = DateTime.Now;
            finishedOrder.EdgePrice = model.EdgePrice;
            finishedOrder.IsExpress = model.IsExpress;
            finishedOrder.UserId = userService.GetUserId();
            finishedOrder.MaterialPrice = model.MaterialPrice;
            finishedOrder.TotalPrice = model.TotalPrice;

            for (int i = 0; i < 12; i++)
            {
                finishedOrder.OrderedMaterials.ElementAt(i).MaterialName = context.Materials
                    .Where(m => m.Id == int.Parse(finishedOrder.OrderedMaterials.ElementAt(i).MaterialName))
                    .Select(m => m.Name)
                    .First().ToString();
            }

            return finishedOrder;
        }
    }
}