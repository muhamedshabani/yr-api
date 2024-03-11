using Microsoft.EntityFrameworkCore;
using yr_api.Data;
using yr_api.Models.Entities;
using yr_api.Repository.Interface;

namespace yr_api.Repository.Repository;

public class FileRepository : IFileRepository
{
    private readonly DatabaseContext _context;
    public FileRepository(DatabaseContext context)
    {
        _context = context;
    }

    public Task<Models.Entities.File> GetFileById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Models.Entities.File>> GetFilesByCabinetId(Guid cabinetId)
    {
        var files = await _context.Files.Where(x => x.Cabinet.Id == cabinetId).ToListAsync();
        return files;
    }

    public async Task<List<Models.Entities.File>> GetFilesByUserId(string userId)
    {
        var files = await _context.Files.Where(x => x.Cabinet.UserId == userId).ToListAsync();
        return files;
    }

    public async Task Update(Guid id, Models.Entities.File file)
    {
        try
        {
            _context.Entry(file).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public Task<int> DeleteFile(Guid id)
    {
        throw new NotImplementedException();
    }

}

