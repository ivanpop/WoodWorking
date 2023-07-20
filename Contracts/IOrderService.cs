﻿using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IOrderService
    {
        Task CreateNewOrderAsync(FinishedOrderViewModel model);

        Task<IEnumerable<AllMaterialsViewModel>> AllMaterialsAsync();

        Task<IEnumerable<AllEdgesViewModel>> GetSelectedEdgesAsync(string id);

        FinishedOrderViewModel ConvertToFinishedOrder(OrderViewModel model);
    }
}