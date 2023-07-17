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
            orderViewModel.Edges = await orderService.GetSelectedEdgesAsync(orderViewModel.UserId);

            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult New(OrderViewModel model)
        {
            model.CreatedDate = DateTime.Now;
            model.UserId = userService.GetUserId();

            if (!ModelState.IsValid)
                return View(model);

            //userId, CreatedDate

            //bool result = await orderService.CreateNewOrderAsync(model);

            //if (!result)
            //{
            //    ViewBag.Error = "error";
            //    return View(model);
            //}

            //return RedirectToAction(nameof(New));

            return View(model);
        }
    }
}