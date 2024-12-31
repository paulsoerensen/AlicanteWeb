using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AlicanteWeb.Data;
public class FileService
{
    private readonly string _uploadFolder;

    public FileService()
    {
        _uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/slide");
        if (!Directory.Exists(_uploadFolder))
        {
            Directory.CreateDirectory(_uploadFolder);
        }
    }

    public async Task<string> UploadFileAsync(IFormFile file, string description)
    {
        if (file == null || file.Length == 0)
        {
            throw new ArgumentException("Invalid file.");
        }

        var fileName = $"{Guid.NewGuid()}-{file.FileName}";
        var filePath = Path.Combine(_uploadFolder, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return fileName; // Return the file name or path as needed
    }
}
