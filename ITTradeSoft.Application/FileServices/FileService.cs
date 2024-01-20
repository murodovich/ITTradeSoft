using ITTradeSoft.Application.Common.Helpers;

using Microsoft.AspNetCore.Http;


namespace ITTradeSoft.Application.FileServices
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly string MEDIA = "media";
        private readonly string IMAGES = "images";
        private readonly string ROOTPATH;

        

        public FileService(IWebHostEnvironment webHost  )
        {
            ROOTPATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _webHost = webHost;
        }

        public async ValueTask<byte[]> GetImageAsync(string filepath)
        {
            string path = Path.Combine(ROOTPATH, filepath);
            byte[] imageBytes = await File.ReadAllBytesAsync(path);
            return imageBytes;
        }

        public async ValueTask<string> UploadFileAsync(IFormFile filePath)
        {
            string newImageName = MediaHelper.MakeFileName(filePath.FileName.ToLower());
            string subPath = Path.Combine(MEDIA, IMAGES, newImageName);
            string path = Path.Combine(ROOTPATH, subPath);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await filePath.CopyToAsync(stream);
                return subPath;
            }
        }

        public async ValueTask<string> UploadImageAsync(IFormFile imagepath)
        {
            string newImageName = MediaHelper.MakeImageName(imagepath.FileName.ToLower());
            var subPath = "/Images/" + Guid.NewGuid() + newImageName;
            //string subPath = Path.Combine(MEDIA, IMAGES, newImageName);
            
            
            string path = ROOTPATH + subPath;

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imagepath.CopyToAsync(stream);
                return subPath;
            }
        }
    }
}
