using System.ComponentModel.DataAnnotations;

namespace NotesManagement.Web.ViewModels
{
    public class UpdateNoteViewModel
    {
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content Required")]
        public string Content { get; set; }
    }
}
