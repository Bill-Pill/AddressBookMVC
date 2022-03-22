namespace AddressBookMVC.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public Task<byte[]> ConvertFileToByteArrayAsync(string fileName);

        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
