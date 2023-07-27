using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WoodWorking.Contracts;
using WoodWorking.Models;
using WoodWorking.Service;

namespace WoodWorking.Controllers
{
    [Authorize(Roles = "admin")]
    public class ContactController : Controller
    {
        private readonly IContactService contactService;
        private readonly IUserService userService;

        public ContactController(IContactService contactService, IUserService userService)
        {
            this.contactService = contactService;
            this.userService = userService;
        }

        public async Task<IActionResult> All()
        {
            var model = await contactService.GetAllContactsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEditContactViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await contactService.AddContactAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await contactService.GetContactForEditAsync(id);

            if (model == null)
                return RedirectToAction(nameof(All));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AddEditContactViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            contactService.EditContactAsync(model, id);

            return RedirectToAction(nameof(All));
        }
    }
}