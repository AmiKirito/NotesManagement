using NotesManagement.BLL.Models;
using System.Collections.Generic;

namespace NotesManagement.BLL.Interfaces.Repositories
{
    public interface INoteRepository
    {
        public Note Get(string noteId);

        public ICollection<Note> GetAll();

        public void Create(Note note);

        public void Update(Note noteToUpdate);

        public void Delete(string noteId);

        public bool CheckIfExists(string noteId);
    }
}
