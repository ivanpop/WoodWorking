using Library.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodWorking.Contracts;
using WoodWorking.Models;

namespace WoodWorking.Controllers
{
    [Authorize]
    public class EdgeController : Controller
    {
        private readonly IEdgeService edgeService;
        private readonly IUserService userService;

        public EdgeController(IEdgeService edgeService, IUserService userService)
        {
            this.edgeService = edgeService;
            this.userService = userService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await edgeService.GetAllEdgesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await edgeService.GetEdgeForEditAsync(id);

            if (model == null)
                return RedirectToAction(nameof(All));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AddEditEdgeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var errorMessages = await edgeService.EditEdgeAsync(model, id);

            if (errorMessages.Count != 0)
            {
                ViewBag.Error = errorMessages;
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
        public async Task<IActionResult> Add(AddEditEdgeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var errorMessages = await edgeService.AddEdgeAsync(model);

            if (errorMessages.Count != 0)
            {
                ViewBag.Error = errorMessages;
                return View(model);
            }

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await edgeService.DeleteMaterialAsync(id);

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> AddtoCollection(int id)
        {
            var edge = await edgeService.GetEdgeByIdAsync(id);

            if (edge == null)
                return RedirectToAction(nameof(All));

            var userId = userService.GetUserId();

            await edgeService.AddEdgeToCollectionAsync(userId, edge);

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Joined()
        {
            var userId = userService.GetUserId();

            var model = await edgeService.GetJoinedEdges(userId);

            return View(model);
        }
    }
}