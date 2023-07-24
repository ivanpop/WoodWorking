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
        public async Task<IActionResult> All(string message)
        {
            var model = await edgeService.GetAllEdgesAsync();

            ViewBag.Message = message;

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

            var isSuccesfull = await edgeService.AddEdgeToCollectionAsync(userId, edge);

            if (isSuccesfull)
                return RedirectToAction(nameof(Joined));
            else
                return (RedirectToAction("All", new { message = "Този кант вече е селектиран!" }));
        }

        public async Task<IActionResult> Joined()
        {
            var userId = userService.GetUserId();

            var model = await edgeService.GetAddedEdges(userId);

            return View(model);
        }

        public async Task<IActionResult> Deselect(int id)
        {
            var edge = await edgeService.GetEdgeByIdAsync(id);

            if (edge == null)
                return RedirectToAction(nameof(Joined));

            var userId = userService.GetUserId();

            await edgeService.RemoveEdgeFromCollectionAsync(userId, edge);

            return RedirectToAction(nameof(Joined));
        }
    }
}