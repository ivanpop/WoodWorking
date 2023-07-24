using System.Security.Claims;
using WoodWorking.Contracts;

namespace Library.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor dbContext;

        public UserService(IHttpContextAccessor dbContext)
        {
            this.dbContext = dbContext;
        }

        public string GetUserId() => dbContext.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
    }
}