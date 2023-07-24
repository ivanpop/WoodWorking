using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;

namespace Library.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor dbContext;
        //private readonly UserManager<WoodWorkingDbContext> userManager;

        public UserService(IHttpContextAccessor dbContext)
        {
            this.dbContext = dbContext;
        }

        public string GetUserId() => dbContext.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;

        //public List<string> GetAllUsers()
        //{
        //    var users = userManager.Users.ToListAsync();

        //    return new List<string>();
        //}
    }
}