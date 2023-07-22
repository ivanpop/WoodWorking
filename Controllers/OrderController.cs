using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using NuGet.DependencyResolver;
using System.Drawing;
using System.Dynamic;
using WoodWorking.Contracts;
using WoodWorking.Data.Models;
using WoodWorking.Models;
using WoodWorking.Service;
using IronBarCode;

namespace WoodWorking.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IUserService userService;

        public OrderController(IOrderService orderService, IUserService userService)
        {
            this.orderService = orderService;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> New()
        {
            OrderViewModel orderViewModel = new OrderViewModel();

            for (int i = 0; i < 12; i++)
            {
                orderViewModel.OrderedMaterials.Add(new OrderedMaterial());
            }

            orderViewModel.Materials = await orderService.AllMaterialsAsync();
            orderViewModel.Edges = await orderService.GetSelectedEdgesAsync(userService.GetUserId());

            return View(orderViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> New(OrderViewModel model)
        {
            var finishedOrder = orderService.ConvertToFinishedOrder(model);

            await orderService.CreateNewOrderAsync(finishedOrder);

            int index = await orderService.GetIdOfLastOrderAsync();

            return RedirectToAction("Get", "Order", new { id = index });
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            FinishedOrderViewModel order = await orderService.GetOrderAsync(id);

            if (order == null || order.UserId != userService.GetUserId())
                return RedirectToAction(nameof(All));

            var materials = await orderService.GetMaterialsANPFAsync();

            for (int i = 0; i < order.OrderedMaterials.Count; i++)
            {
                var selectedMaterial = order.OrderedMaterials.ElementAt(i);

                string anpf = materials.
                    Where(m => m.Name == selectedMaterial.MaterialName)
                    .Select(m => m.ANPF).First();

                BarcodeWriter.CreateBarcode(selectedMaterial.MaterialQuadrature + "*" + anpf, BarcodeWriterEncoding.Code128)
                .AddAnnotationTextBelowBarcode(selectedMaterial.MaterialQuadrature + "*" + anpf)
                .ResizeTo(60, 50)
                .SaveAsJpeg("wwwroot\\barcodes\\" + order.UserId + "\\" + (i + 1) + ".jpg");
            }

            return View(order);
        }

        [HttpGet]
        public async Task<IActionResult> All(int? pageNumber)
        {
            int pageSize = 5;

            var order = await orderService.AllOrdersByUserAsync(userService.GetUserId());
            
            return View(PaginatedList<AllOrdersViewModel>.Create(order.ToList(), pageNumber ?? 1, pageSize));
        }
    }
}