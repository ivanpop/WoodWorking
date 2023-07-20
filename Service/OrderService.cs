using Library.Services;
using Microsoft.AspNetCore.Components.Forms;
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

        public async Task CreateNewOrderAsync(FinishedOrderViewModel model)
        {
            Order order = new Order();

            order.ClientName = model.ClientName;
            order.ClientPhone = model.ClientPhone;
            order.CreatedDate = model.CreatedDate;
            order.EdgePrice = model.EdgePrice;
            order.IsExpress = model.IsExpress;
            order.MaterialPrice = model.MaterialPrice;
            order.TotalPrice = model.TotalPrice;
            order.UserId = model.UserId;
            order.OrderedMaterials = model.OrderedMaterials;

            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
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

        public FinishedOrderViewModel ConvertToFinishedOrder(OrderViewModel model)
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
                var selectedElement = finishedOrder.OrderedMaterials.ElementAt(i);

                if  (selectedElement.MaterialName != "0")
                {
                    var materialNameAndPrice = context.Materials
                        .Where(m => m.Id == int.Parse(finishedOrder.OrderedMaterials.ElementAt(i).MaterialName))
                        .Select(m => new
                        {
                            m.Name,
                            m.Price
                        }).First();

                    selectedElement.MaterialName = materialNameAndPrice.Name;
                    selectedElement.MaterialPrice = materialNameAndPrice.Price;

                    if (selectedElement.MaterialEdgeTotalPrice != 0)
                    {
                        selectedElement.MaterialEdgeL1Price = selectedElement.MaterialEdgeL1;
                        selectedElement.MaterialEdgeL2Price = selectedElement.MaterialEdgeL2;
                        selectedElement.MaterialEdgeH1Price = selectedElement.MaterialEdgeH1;
                        selectedElement.MaterialEdgeH2Price = selectedElement.MaterialEdgeH2;

                        var edgeMeasurement = context.IdentityUserEdges
                            .Where(ue => ue.UserId == finishedOrder.UserId)
                            .Select(e => new
                            {
                                Edge = e.Edge.Height,
                                e.Edge.Price
                            });

                        selectedElement.MaterialEdgeL1 = edgeMeasurement.Where(e => e.Price == selectedElement.MaterialEdgeL1).Select(e => e.Edge).FirstOrDefault();
                        selectedElement.MaterialEdgeL2 = edgeMeasurement.Where(e => e.Price == selectedElement.MaterialEdgeL2).Select(e => e.Edge).FirstOrDefault();
                        selectedElement.MaterialEdgeH1 = edgeMeasurement.Where(e => e.Price == selectedElement.MaterialEdgeH1).Select(e => e.Edge).FirstOrDefault();
                        selectedElement.MaterialEdgeH2 = edgeMeasurement.Where(e => e.Price == selectedElement.MaterialEdgeH2).Select(e => e.Edge).FirstOrDefault();
                    }
                }
            }

            return finishedOrder;
        }
    }
}