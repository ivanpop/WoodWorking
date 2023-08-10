using Microsoft.EntityFrameworkCore;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;
using WoodWorking.Service;

namespace WoodWorking.Services.Tests
{
    //23.78%
    public class ContactTest
    {
        private DbContextOptions<WoodWorkingDbContext> dbOptions;
        private WoodWorkingDbContext dbContext;
        private IContactService contactService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<WoodWorkingDbContext>()
                .UseInMemoryDatabase("WoodWorkingInMemoryDb" + DateTime.Now.Ticks.ToString())
                .Options;

            dbContext = new WoodWorkingDbContext(dbOptions);

            DatabaseSeeder.SeedDatabase(dbContext);

            this.contactService = new ContactService(dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllContactsTest()
        {
            var contactsFromService = contactService.GetAllContactsAsync();

            var contactsFromDb = dbContext.Contacts
                .Select(e => new AllContactsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Phone = e.Phone,
                    ImageUrl = e.ImageUrl
                }).ToList();

            Assert.That(contactsFromService.Result.Count(), Is.EqualTo(contactsFromDb.Count));

            Assert.That(contactsFromService.Result.First().Id, Is.EqualTo(contactsFromDb.First().Id));
            Assert.That(contactsFromService.Result.First().Name, Is.EqualTo(contactsFromDb.First().Name));
            Assert.That(contactsFromService.Result.First().Address, Is.EqualTo(contactsFromDb.First().Address));
            Assert.That(contactsFromService.Result.First().Phone, Is.EqualTo(contactsFromDb.First().Phone));
            Assert.That(contactsFromService.Result.First().ImageUrl, Is.EqualTo(contactsFromDb.First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(1).First().Id, Is.EqualTo(contactsFromDb.Skip(1).First().Id));
            Assert.That(contactsFromService.Result.Skip(1).First().Name, Is.EqualTo(contactsFromDb.Skip(1).First().Name));
            Assert.That(contactsFromService.Result.Skip(1).First().Address, Is.EqualTo(contactsFromDb.Skip(1).First().Address));
            Assert.That(contactsFromService.Result.Skip(1).First().Phone, Is.EqualTo(contactsFromDb.Skip(1).First().Phone));
            Assert.That(contactsFromService.Result.Skip(1).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(1).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(2).First().Id, Is.EqualTo(contactsFromDb.Skip(2).First().Id));
            Assert.That(contactsFromService.Result.Skip(2).First().Name, Is.EqualTo(contactsFromDb.Skip(2).First().Name));
            Assert.That(contactsFromService.Result.Skip(2).First().Address, Is.EqualTo(contactsFromDb.Skip(2).First().Address));
            Assert.That(contactsFromService.Result.Skip(2).First().Phone, Is.EqualTo(contactsFromDb.Skip(2).First().Phone));
            Assert.That(contactsFromService.Result.Skip(2).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(2).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(3).First().Id, Is.EqualTo(contactsFromDb.Skip(3).First().Id));
            Assert.That(contactsFromService.Result.Skip(3).First().Name, Is.EqualTo(contactsFromDb.Skip(3).First().Name));
            Assert.That(contactsFromService.Result.Skip(3).First().Address, Is.EqualTo(contactsFromDb.Skip(3).First().Address));
            Assert.That(contactsFromService.Result.Skip(3).First().Phone, Is.EqualTo(contactsFromDb.Skip(3).First().Phone));
            Assert.That(contactsFromService.Result.Skip(3).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(3).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(4).First().Id, Is.EqualTo(contactsFromDb.Skip(4).First().Id));
            Assert.That(contactsFromService.Result.Skip(4).First().Name, Is.EqualTo(contactsFromDb.Skip(4).First().Name));
            Assert.That(contactsFromService.Result.Skip(4).First().Address, Is.EqualTo(contactsFromDb.Skip(4).First().Address));
            Assert.That(contactsFromService.Result.Skip(4).First().Phone, Is.EqualTo(contactsFromDb.Skip(4).First().Phone));
            Assert.That(contactsFromService.Result.Skip(4).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(4).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(5).First().Id, Is.EqualTo(contactsFromDb.Skip(5).First().Id));
            Assert.That(contactsFromService.Result.Skip(5).First().Name, Is.EqualTo(contactsFromDb.Skip(5).First().Name));
            Assert.That(contactsFromService.Result.Skip(5).First().Address, Is.EqualTo(contactsFromDb.Skip(5).First().Address));
            Assert.That(contactsFromService.Result.Skip(5).First().Phone, Is.EqualTo(contactsFromDb.Skip(5).First().Phone));
            Assert.That(contactsFromService.Result.Skip(5).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(5).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(6).First().Id, Is.EqualTo(contactsFromDb.Skip(6).First().Id));
            Assert.That(contactsFromService.Result.Skip(6).First().Name, Is.EqualTo(contactsFromDb.Skip(6).First().Name));
            Assert.That(contactsFromService.Result.Skip(6).First().Address, Is.EqualTo(contactsFromDb.Skip(6).First().Address));
            Assert.That(contactsFromService.Result.Skip(6).First().Phone, Is.EqualTo(contactsFromDb.Skip(6).First().Phone));
            Assert.That(contactsFromService.Result.Skip(6).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(6).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(7).First().Id, Is.EqualTo(contactsFromDb.Skip(7).First().Id));
            Assert.That(contactsFromService.Result.Skip(7).First().Name, Is.EqualTo(contactsFromDb.Skip(7).First().Name));
            Assert.That(contactsFromService.Result.Skip(7).First().Address, Is.EqualTo(contactsFromDb.Skip(7).First().Address));
            Assert.That(contactsFromService.Result.Skip(7).First().Phone, Is.EqualTo(contactsFromDb.Skip(7).First().Phone));
            Assert.That(contactsFromService.Result.Skip(7).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(7).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(8).First().Id, Is.EqualTo(contactsFromDb.Skip(8).First().Id));
            Assert.That(contactsFromService.Result.Skip(8).First().Name, Is.EqualTo(contactsFromDb.Skip(8).First().Name));
            Assert.That(contactsFromService.Result.Skip(8).First().Address, Is.EqualTo(contactsFromDb.Skip(8).First().Address));
            Assert.That(contactsFromService.Result.Skip(8).First().Phone, Is.EqualTo(contactsFromDb.Skip(8).First().Phone));
            Assert.That(contactsFromService.Result.Skip(8).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(8).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(9).First().Id, Is.EqualTo(contactsFromDb.Skip(9).First().Id));
            Assert.That(contactsFromService.Result.Skip(9).First().Name, Is.EqualTo(contactsFromDb.Skip(9).First().Name));
            Assert.That(contactsFromService.Result.Skip(9).First().Address, Is.EqualTo(contactsFromDb.Skip(9).First().Address));
            Assert.That(contactsFromService.Result.Skip(9).First().Phone, Is.EqualTo(contactsFromDb.Skip(9).First().Phone));
            Assert.That(contactsFromService.Result.Skip(9).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(9).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(10).First().Id, Is.EqualTo(contactsFromDb.Skip(10).First().Id));
            Assert.That(contactsFromService.Result.Skip(10).First().Name, Is.EqualTo(contactsFromDb.Skip(10).First().Name));
            Assert.That(contactsFromService.Result.Skip(10).First().Address, Is.EqualTo(contactsFromDb.Skip(10).First().Address));
            Assert.That(contactsFromService.Result.Skip(10).First().Phone, Is.EqualTo(contactsFromDb.Skip(10).First().Phone));
            Assert.That(contactsFromService.Result.Skip(10).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(10).First().ImageUrl));

            Assert.That(contactsFromService.Result.Skip(11).First().Id, Is.EqualTo(contactsFromDb.Skip(11).First().Id));
            Assert.That(contactsFromService.Result.Skip(11).First().Name, Is.EqualTo(contactsFromDb.Skip(11).First().Name));
            Assert.That(contactsFromService.Result.Skip(11).First().Address, Is.EqualTo(contactsFromDb.Skip(11).First().Address));
            Assert.That(contactsFromService.Result.Skip(11).First().Phone, Is.EqualTo(contactsFromDb.Skip(11).First().Phone));
            Assert.That(contactsFromService.Result.Skip(11).First().ImageUrl, Is.EqualTo(contactsFromDb.Skip(11).First().ImageUrl));
        }

        [Test]
        public void AddContactTest()
        {
            AddEditContactViewModel contact = new AddEditContactViewModel();

            contact.Name = "Name";
            contact.Address = "Address";
            contact.Phone = "Phone";
            contact.ImageUrl = "Url";

            var contactsBeforeAdd = contactService.GetAllContactsAsync();

            contactService.AddContactAsync(contact);

            var contactsAfterAdd = contactService.GetAllContactsAsync();

            Assert.That(contactsBeforeAdd.Result.Count() + 1, Is.EqualTo(contactsAfterAdd.Result.Count()));
            Assert.That(contactsAfterAdd.Result.Last().Phone, Is.EqualTo(contact.Phone));
            Assert.That(contactsAfterAdd.Result.Last().Address, Is.EqualTo(contact.Address));
            Assert.That(contactsAfterAdd.Result.Last().Name, Is.EqualTo(contact.Name));
            Assert.That(contactsAfterAdd.Result.Last().ImageUrl, Is.EqualTo(contact.ImageUrl));
        }

        [Test]
        public void GetContactForEditTest()
        {
            var originalContact = contactService.GetContactForEditAsync(5);

            var contact = dbContext.Contacts
                .Where(e => e.Id == 5)
                .Select(e => new AddEditContactViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Phone = e.Phone,
                    ImageUrl = e.ImageUrl
                }).FirstOrDefault();

            Assert.That(originalContact.Result.Name, Is.EqualTo(contact.Name));
            Assert.That(originalContact.Result.ImageUrl, Is.EqualTo(contact.ImageUrl));
            Assert.That(originalContact.Result.Address, Is.EqualTo(contact.Address));
            Assert.That(originalContact.Result.Id, Is.EqualTo(contact.Id));
            Assert.That(originalContact.Result.Id, Is.EqualTo(5));
        }

        [Test]
        public void EditContactTest()
        {
            OneTimeSetUp();

            AddEditContactViewModel contact = new AddEditContactViewModel();

            contact.Name = "Name";
            contact.Address = "Address";
            contact.Phone = "Phone";
            contact.ImageUrl = "Url";

            contactService.EditContactAsync(contact, 5);

            var editedContact = contactService.GetContactForEditAsync(5);

            Assert.That(editedContact.Result.Name, Is.EqualTo(contact.Name));
            Assert.That(editedContact.Result.ImageUrl, Is.EqualTo(contact.ImageUrl));
            Assert.That(editedContact.Result.Address, Is.EqualTo(contact.Address));
            Assert.That(editedContact.Result.Id, Is.EqualTo(5));
        }

        [Test]
        public void GetAllStoresForAssociateTest()
        {
            var stores = contactService.GetAllStoresForAssociateAsync();
            var directStores = dbContext.Users.Select(u => u.UserName).ToList();

            Assert.That(stores.Result.Count, Is.EqualTo(directStores.Count));
        }

        [Test]
        public void GetAllContactsForAssociateTest()
        {
            var contacts = contactService.GetAllContactsForAssociateAsync();
            var directContacts = dbContext.Contacts.Select(c => c.Name).ToList();

            Assert.That(contacts.Result.Count, Is.EqualTo(directContacts.Count));
        }

        [Test]
        public void AssociateTest()
        {
            var model = new StoreToContactViewModel();

            model.ContactName = "             ";
            model.StoreName = "trade@mr-bricolage.bg";

            int count = dbContext.IdentityUserContacts.Count();

            contactService.AddAssociationAsync(model);

            Assert.That(dbContext.IdentityUserContacts.Count(), Is.EqualTo(count));
            Assert.That(model.Stores.Count, Is.EqualTo(0));
            Assert.That(model.Contacts.Count, Is.EqualTo(0));
            Assert.That(model.ContactName, Is.EqualTo("             "));
            Assert.That(model.StoreName, Is.EqualTo("trade@mr-bricolage.bg"));
        }
    }
}