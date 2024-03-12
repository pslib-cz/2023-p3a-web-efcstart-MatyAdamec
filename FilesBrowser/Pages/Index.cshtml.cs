using FilesBrowser.Data;
using FilesBrowser.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FilesBrowser.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        private readonly ILogger<IndexModel> _logger;
        public Guid? OpenFolderId { get; set; }

        public List<Folder> Folders { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _context = context;
        }

        public void OnGet(Guid? openId)
        {
            // Always load the top-level folders
            Folders = _context.Folders
                              .Where(f => f.ParentFolderId == null)
                              .ToList();

            if (openId.HasValue)
            {
                // Find and load subfolders of the folder that has been opened
                var subfolders = _context.Folders
                                         .Where(f => f.ParentFolderId == openId.Value)
                                         .ToList();

                // Find the opened folder and set its Subfolders property
                var openedFolder = Folders.FirstOrDefault(f => f.FolderId == openId.Value);
                if (openedFolder != null)
                {
                    openedFolder.Subfolders = subfolders;
                }
            }
        }

    }
}
