using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Data.Models;
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

        public async Task AddContactAsync(AddEditContactViewModel model)
        {
            Contact contact = new Contact();

            contact.Name = model.Name;
            contact.Address = model.Address;
            contact.Phone = model.Phone;
            contact.ImageUrl = model.ImageUrl;

            await context.Contacts.AddAsync(contact);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllContactsViewModel>> GetAllContactsAsync()
        {
            return await context.Contacts
                .Select(e => new AllContactsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Phone = e.Phone,
                    ImageUrl = e.ImageUrl
                }).ToListAsync();
        }

        public async Task<AddEditContactViewModel?> GetContactForEditAsync(int id)
        {
            return await context.Contacts
                .Where(e => e.Id == id)
                .Select(e => new AddEditContactViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Phone = e.Phone,
                    ImageUrl = e.ImageUrl
                }).FirstOrDefaultAsync();
        }

        public async Task EditContactAsync(AddEditContactViewModel model, int id)
        {
            var contact = await context.Contacts.FindAsync(id);

            contact!.Name = model.Name;
            contact.Address = model.Address;
            contact.Phone = model.Phone;
            contact.ImageUrl = model.ImageUrl;

            await context.SaveChangesAsync();
        }

        public async Task DeleteContactAsync(int id)
        {
            var contact = await context.Contacts.FindAsync(id);

            if (contact != null)
            {
                context.Contacts.Remove(contact);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> GetAllStoresForAssociateAsync() => await context.Users.Select(u => u.UserName).ToListAsync();

        public async Task<List<string>> GetAllContactsForAssociateAsync() => await context.Contacts.Select(c => c.Name).ToListAsync();

        public async Task AddAssociationAsync(StoreToContactViewModel model)
        {
            IdentityUserContact identityUserContact = new IdentityUserContact();

            identityUserContact.UserId = await context.Users
                .Where(u => u.UserName == model.StoreName)
                .Select(u => u.Id)
                .FirstOrDefaultAsync();

            identityUserContact.ContactId = await context.Contacts
                .Where(c => c.Name == model.ContactName)
                .Select(c => c.Id)
                .FirstOrDefaultAsync();

            var selectedUser = await context.IdentityUserContacts
                .Where(uc => uc.UserId == identityUserContact.UserId).FirstOrDefaultAsync();

            if (selectedUser != null)
            {
                context.IdentityUserContacts.Remove(selectedUser);
                context.SaveChanges();
            }

            context.IdentityUserContacts.Add(identityUserContact);
            await context.SaveChangesAsync();
        }
    }
}