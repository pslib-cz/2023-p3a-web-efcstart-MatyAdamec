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
            var MusicId = Guid.NewGuid();
            var ImagesId = Guid.NewGuid();
            var GymPlaylistId = Guid.NewGuid();
            var WhiteGirlMusicId = Guid.NewGuid();
            var MyMomPhotosId = Guid.NewGuid();
            var MyDadPhotosId = Guid.NewGuid();

            modelBuilder.Entity<Folder>().HasData(
                new Folder { FolderId = MusicId, Name = "Music", ParentFolderId = null },
                new Folder { FolderId = ImagesId, Name = "Images", ParentFolderId = null },
                new Folder { FolderId = GymPlaylistId, Name = "GymPlalist", ParentFolderId = MusicId },
                new Folder { FolderId = WhiteGirlMusicId, Name = "WhiteGirlMusic", ParentFolderId = MusicId },
                new Folder { FolderId = MyMomPhotosId, Name = "MyMomPhotos", ParentFolderId = ImagesId },
                new Folder { FolderId = MyDadPhotosId, Name = "MyDadPhotos", ParentFolderId = ImagesId }
            );
        }

    }
}
