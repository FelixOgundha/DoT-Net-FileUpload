namespace FileUpload.Entities
{
    public class FileDetail
    {
        public int Id { get; set; }
        public string FileName { get; set; } = String.Empty;
        public byte[] FileData { get; set; } 
        public FileType FileType { get; set; }
    }
}
