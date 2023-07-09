using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodWorking.Contracts;
using WoodWorking.Models;
using WoodWorking.Service;

namespace WoodWorking.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
                this.orderService = orderService;
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GetOrderViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            //bool result = await orderService.CreateNewOrderAsync(model);

            //if (!result)
            //{
            //    ViewBag.Error = "error";
            //    return View(model);
            //}

            return RedirectToAction(nameof(New));
        }
    }
}