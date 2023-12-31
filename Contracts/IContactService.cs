﻿using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IContactService
    {
        Task<IEnumerable<AllContactsViewModel>> GetAllContactsAsync();

        Task AddContactAsync(AddEditContactViewModel model);

        Task<AddEditContactViewModel?> GetContactForEditAsync(int id);

        Task EditContactAsync(AddEditContactViewModel model, int id);

        Task DeleteContactAsync(int id);

        Task<List<string>> GetAllStoresForAssociateAsync();

        Task<List<string>> GetAllContactsForAssociateAsync();

        Task AddAssociationAsync(StoreToContactViewModel model);
    }
}