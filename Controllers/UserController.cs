using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WoodWorking.Contracts;

namespace WoodWorking.Controllers
{
    [Authorize(Roles = "admin")]
    public class UserController : Controller
    {
        //private readonly IUserService userService;

        public IActionResult Index()
        {
            //var users = userService.GetAllUsers();
            return View();
        }
    }
}