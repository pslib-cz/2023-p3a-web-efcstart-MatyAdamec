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

        public List<Folder> Folders { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            Folders = _context.Folders.ToList();
        }
    }
}
