using FileUpload.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileUpload.Data
{
    public class UploadDbContext: DbContext
    {
        public UploadDbContext(DbContextOptions<UploadDbContext> options) : base(options)
        {
                
        }
        public DbSet<FileDetail> FileDetails { get; set; }
    }
}
