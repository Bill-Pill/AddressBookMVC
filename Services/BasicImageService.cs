using AddressBookMVC.Services.Interfaces;

namespace AddressBookMVC.Services
{
    public class BasicImageService : IImageService
    {
        public string ConvertByteArrayToFile(byte[] fileData, string extension)
        {
            if (fileData is null) return string.Empty;

            string imageBase64data = Convert.ToBase64String(fileData);
            return $"data:{extension};base64,{imageBase64data}";
        }

        public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
        {
            using MemoryStream memoryStream = new();
            await file.CopyToAsync(memoryStream);
            byte[] byteFile = memoryStream.ToArray();

            return byteFile;
        }

        public async Task<byte[]> ConvertFileToByteArrayAsync(string fileName)
        {
            var file = $"{Directory.GetCurrentDirectory()}/wwwroot/img/{fileName}";
            return await File.ReadAllBytesAsync(file);
        }
    }
}
