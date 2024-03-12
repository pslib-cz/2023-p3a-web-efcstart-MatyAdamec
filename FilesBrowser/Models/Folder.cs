using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilesBrowser.Models
{
    public class Folder
    {
        [Key]
        public Guid FolderId { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid? ParentFolderId { get; set; }

        [ForeignKey("ParentFolderId")]
        public Folder ParentFolder { get; set; }
        public ICollection<Folder> Subfolders { get; set; }

    }
}
