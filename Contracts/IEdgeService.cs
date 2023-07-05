﻿using WoodWorking.Models;

namespace WoodWorking.Contracts
{
    public interface IEdgeService
    {
        Task<List<string>> AddEdgeAsync(AddEditEdgeViewModel model);

        Task DeleteMaterialAsync(int id);

        Task<List<string>> EditEdgeAsync(AddEditEdgeViewModel model, int id);

        Task<IEnumerable<AllEdgesViewModel>> GetAllEdgesAsync();

        Task<AddEditEdgeViewModel> GetEdgeForEditAsync(int id);
    }
}