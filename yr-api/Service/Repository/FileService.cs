using Microsoft.EntityFrameworkCore;
using yr_api.Repository.Interface;
using yr_api.Service.Interface;

namespace yr_api.Service.Service;

public class FileService : IFileService
{
    private readonly IFileRepository _fileRepository;

    public FileService(IFileRepository fileRepository)
    {
        _fileRepository = fileRepository;
    }

    public Task<Models.Entities.File> GetFileById(string userId, Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Models.Entities.File>> GetFiles(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteFile(string userId, Guid id)
    {
        throw new NotImplementedException();
    }
}

