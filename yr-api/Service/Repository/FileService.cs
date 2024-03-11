using System;
using Microsoft.EntityFrameworkCore;
using yr_api.Data;
using yr_api.Service.Interface;

namespace yr_api.Service.Service;

public class FileService : IFileService
{
    private readonly DatabaseContext _context;

    public FileService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<Models.Entities.File>> GetFiles()
    {
        var files = await _context.Files.ToListAsync();
        return files;
    }
}

