using NotesManagement.BLL.Interfaces.Repositories;
using NotesManagement.BLL.Interfaces.Services;
using NotesManagement.BLL.Models;
using System;
using System.Collections.Generic;

namespace NotesManagement.BLL.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public Note Get(string noteId)
        {
            return _noteRepository.Get(noteId);
        }

        public ICollection<Note> GetAll()
        {
            return _noteRepository.GetAll();
        }

        public void Create(Note note)
        {
            note.Id = GenerateNoteId();

            _noteRepository.Create(note);
        }

        public void Detele(string noteId)
        {
            _noteRepository.Delete(noteId);
        }

        public void Update(Note noteToUpdate)
        {
            _noteRepository.Update(noteToUpdate);
        }

        public bool CheckIfExists(string noteId)
        {
            return _noteRepository.CheckIfExists(noteId);
        }

        private string GenerateNoteId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
