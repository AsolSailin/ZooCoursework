namespace ZooCoursework.Services
{
    public class FileSystemService
    {
        public async Task UploadFileAsync(string name, Stream stream)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", name);
            using var fs = new FileStream(path, FileMode.Create);
            await stream.CopyToAsync(fs);
        }
    }
}
