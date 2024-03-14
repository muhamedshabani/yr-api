namespace yr_api.Repository.Interface;

public interface IFileRepository
{
    public Task<Models.Entities.File> GetFileById(Guid id);
    public Task<List<Models.Entities.File>> GetFilesByCabinetId(Guid userId);
    public Task<List<Models.Entities.File>> GetFilesByUserId(string userId);
    public Task Update(Guid id, Models.Entities.File file);
    public Task<int> DeleteFile(Guid id);
}

