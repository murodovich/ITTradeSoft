using Microsoft.AspNetCore.Http;

namespace ITTradeSoft.Application.FileServices
{
    public interface IFileService
    {
        public ValueTask<string> UploadImageAsync(IFormFile imagepath);
        public ValueTask<byte[]> GetImageAsync(string path);
        public ValueTask<string> UploadFileAsync(IFormFile filePath);
    }
}
