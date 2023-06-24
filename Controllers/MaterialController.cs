using Microsoft.AspNetCore.Mvc;
using WoodWorking.Contracts;

namespace WoodWorking.Controllers
{
    public class MaterialController : Controller
    {
        private readonly IMaterialService materialService;

        public MaterialController(IMaterialService materialService)
        {
            this.materialService = materialService;
        }

        public async Task<IActionResult> All()
        {
            var model = await materialService.GetAllMaterialsAsync();

            return View(model);
        }
    }
}