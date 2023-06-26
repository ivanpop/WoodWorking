using Microsoft.AspNetCore.Mvc;
using WoodWorking.Contracts;
using WoodWorking.Models;

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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await materialService.GetMaterialForEditAsync(id);

            if (model == null)
                return RedirectToAction(nameof(All));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditMaterialViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await materialService.EditBookAsync(model, id);

            return RedirectToAction(nameof(All));
        }
    }
}