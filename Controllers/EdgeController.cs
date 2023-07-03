using Microsoft.AspNetCore.Mvc;
using WoodWorking.Contracts;
using WoodWorking.Service;

namespace WoodWorking.Controllers
{
    public class EdgeController : Controller
    {
        private readonly IEdgeService edgeService;

        public EdgeController(IEdgeService edgeService)
        {
            this.edgeService = edgeService;
        }

        public async Task<IActionResult> All()
        {
            var model = await edgeService.GetAllEdgesAsync();

            return View(model);
        }
    }
}