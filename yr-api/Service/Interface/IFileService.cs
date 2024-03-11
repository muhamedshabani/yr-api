using System;
namespace yr_api.Service.Interface;

public interface IFileService
{
    public Task<List<Models.Entities.File>> GetFiles();
    public Task<Models.Entities.File> GetFileById(Guid cabinetId, Guid id);
    public Task<int> DeleteFile(Guid cabinetId, Guid id, string userId);
}

