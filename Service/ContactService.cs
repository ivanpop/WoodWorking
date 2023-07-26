using Microsoft.EntityFrameworkCore;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;

namespace WoodWorking.Service
{
    public class ContactService : IContactService
    {
        private readonly WoodWorkingDbContext context;

        public ContactService(WoodWorkingDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AllContactsViewModel>> GetAllContactsAsync()
        {
            return await context.Contacts
                .Select(e => new AllContactsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Phone = e.Phone
                }).ToListAsync();
        }
    }
}