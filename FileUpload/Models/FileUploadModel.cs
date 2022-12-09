using FileUpload.Entities;

namespace FileUpload.Models
{
    public class FileUploadModel
    {
        public IFormFile FileDetail { get; set; }
        public FileType FileType { get; set; }
    }
}
