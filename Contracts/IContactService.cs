using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IContactService
    {
        Task<IEnumerable<AllContactsViewModel>> GetAllContactsAsync();
    }
}