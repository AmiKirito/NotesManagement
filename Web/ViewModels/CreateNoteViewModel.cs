using System.ComponentModel.DataAnnotations;

namespace NotesManagement.Web.ViewModels
{
    public class CreateNoteViewModel
    {
        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content Required")]
        public string Content { get; set; }
    }
}
