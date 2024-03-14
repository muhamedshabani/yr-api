using System;
namespace yr_api.Service.Interface;

public interface IFileService
{
    public Task<List<Models.Entities.File>> GetFiles(string userId);
    public Task<Models.Entities.File> GetFileById(string userId, Guid id);
    public Task<int> DeleteFile(string userId, Guid id);
}

