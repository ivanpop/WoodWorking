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
        public async Task<IActionResult> Edit(int id, AddEditMaterialViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            bool result = await materialService.EditBookAsync(model, id);

            if (!result)
            { 
                ViewBag.Error = "error";
                return View(model);
            }                

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEditMaterialViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            bool result = await materialService.AddMaterialAsync(model);

            if (!result)
            {
                ViewBag.Error = "error";
                return View(model);
            }

            return RedirectToAction(nameof(All));
        }
    }
}