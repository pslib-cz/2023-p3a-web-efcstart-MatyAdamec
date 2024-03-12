using FilesBrowser.Models;
using Microsoft.EntityFrameworkCore;

namespace FilesBrowser.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Folder> Folders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ImagesId = Guid.NewGuid();
            var MyPhotosId = Guid.NewGuid();
            var MusicId = Guid.NewGuid();
            var YeMusicId = Guid.NewGuid();
            var YourPhotosId = Guid.NewGuid();
            var GymPlaylistId = Guid.NewGuid();

            modelBuilder.Entity<Folder>().HasData(
                new Folder { FolderId = MusicId, Name = "Music", ParentFolderId = null },
                new Folder { FolderId = GymPlaylistId, Name = "gym", ParentFolderId = MusicId },
                new Folder { FolderId = YeMusicId, Name = "Ye", ParentFolderId = MusicId },
                new Folder { FolderId = ImagesId, Name = "Images", ParentFolderId = null },
                new Folder { FolderId = YourPhotosId, Name = "YourPhotos", ParentFolderId = ImagesId },
                new Folder { FolderId = MyPhotosId, Name = "MyPhotos", ParentFolderId = ImagesId }
            );
        }

    }
}
