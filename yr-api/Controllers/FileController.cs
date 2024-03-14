using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using yr_api.Service.Interface;

namespace yr_api.Controllers;

public class FileController : ControllerBase
{
    private readonly IFileService _fileService;
    public FileController(IFileService fileService)
    {
        _fileService = fileService;
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetFileById(Guid id)
    {
        var userId = User.FindFirst(ClaimTypes.Sid!).Value;
        var file = await _fileService.GetFileById(userId, id);
        return Ok(file);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetFiles()
    {
        var userId = User.FindFirst(ClaimTypes.Sid!).Value;
        var files = await _fileService.GetFiles(userId);
        return Ok(files);
    }
}

