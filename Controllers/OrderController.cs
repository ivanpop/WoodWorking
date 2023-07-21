using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;
using System.Dynamic;
using WoodWorking.Contracts;
using WoodWorking.Data.Models;
using WoodWorking.Models;
using WoodWorking.Service;

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

            return RedirectToAction(nameof(New));
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            FinishedOrderViewModel order = await orderService.GetOrderAsync(id);

            if (order == null || order.UserId != userService.GetUserId())
                return RedirectToAction(nameof(All));

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