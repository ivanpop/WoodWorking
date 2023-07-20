using Microsoft.EntityFrameworkCore;
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

            finishedOrder.OrderedMaterials = model.OrderedMaterials.Where(om => om.MaterialPrice != 0).ToList();
            finishedOrder.ClientName = model.ClientName;
            finishedOrder.ClientPhone = model.ClientPhone;
            finishedOrder.CreatedDate = DateTime.Now;
            finishedOrder.EdgePrice = model.EdgePrice;
            finishedOrder.IsExpress = model.IsExpress;
            finishedOrder.UserId = userService.GetUserId();
            finishedOrder.MaterialPrice = model.MaterialPrice;
            finishedOrder.TotalPrice = model.TotalPrice;


            foreach (var orderedMaterial in finishedOrder.OrderedMaterials)
            {
                var materialNameAndPrice = context.Materials
                        .Where(m => m.Id == int.Parse(orderedMaterial.MaterialName))
                        .Select(m => new
                        {
                            m.Name,
                            m.Price
                        }).First();

                orderedMaterial.MaterialName = materialNameAndPrice.Name;
                orderedMaterial.MaterialPrice = materialNameAndPrice.Price;

                if (orderedMaterial.MaterialEdgeTotalPrice != 0)
                {
                    orderedMaterial.MaterialEdgeL1Price = orderedMaterial.MaterialEdgeL1;
                    orderedMaterial.MaterialEdgeL2Price = orderedMaterial.MaterialEdgeL2;
                    orderedMaterial.MaterialEdgeH1Price = orderedMaterial.MaterialEdgeH1;
                    orderedMaterial.MaterialEdgeH2Price = orderedMaterial.MaterialEdgeH2;

                    var edgeMeasurement = context.IdentityUserEdges
                        .Where(ue => ue.UserId == finishedOrder.UserId)
                        .Select(e => new
                        {
                            Edge = e.Edge.Height,
                            e.Edge.Price
                        });

                    orderedMaterial.MaterialEdgeL1 = edgeMeasurement.Where(e => e.Price == orderedMaterial.MaterialEdgeL1).Select(e => e.Edge).FirstOrDefault();
                    orderedMaterial.MaterialEdgeL2 = edgeMeasurement.Where(e => e.Price == orderedMaterial.MaterialEdgeL2).Select(e => e.Edge).FirstOrDefault();
                    orderedMaterial.MaterialEdgeH1 = edgeMeasurement.Where(e => e.Price == orderedMaterial.MaterialEdgeH1).Select(e => e.Edge).FirstOrDefault();
                    orderedMaterial.MaterialEdgeH2 = edgeMeasurement.Where(e => e.Price == orderedMaterial.MaterialEdgeH2).Select(e => e.Edge).FirstOrDefault();
                }
            }

            return finishedOrder;
        }
    }
}