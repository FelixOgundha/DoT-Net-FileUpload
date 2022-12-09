using FileUpload.Entities;
using FileUpload.Models;

namespace FileUpload.Services.FileUpload
{
    public interface IFileService
    {
        public Task PostFileAsync(IFormFile fileData, FileType fileType);

        public Task PostMultiFileAsync(List<FileUploadModel> fileData);

        public Task DownloadFileById(int id);
    }
}
