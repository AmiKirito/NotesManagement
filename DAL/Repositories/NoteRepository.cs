using AutoMapper;
using NotesManagement.BLL.Interfaces.Repositories;
using NotesManagement.BLL.Models;
using NotesManagement.DAL.ModelEntities;
using System.Collections.Generic;
using System.Linq;

namespace NotesManagement.DAL.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public NoteRepository(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Note Get(string noteId)
        {
            var noteEntity = _context.Notes.Single(x => x.Id == noteId);

            var note = _mapper.Map<Note>(noteEntity);

            return note;
        }

        public ICollection<Note> GetAll()
        {
            var noteEntities = _context.Notes?.Where(x => !x.IsRemoved).ToList();

            var notes = _mapper.Map<List<Note>>(noteEntities);

            return notes;
        }

        public void Create(Note note)
        {
            var noteToCreate = _mapper.Map<NoteEntity>(note);

            _context.Notes.Add(noteToCreate);

            _context.SaveChanges();
        }

        public void Delete(string noteId)
        {
            var noteEntity = _context.Notes
                .Single(x => x.Id == noteId)
                .IsRemoved = true;

            _context.SaveChanges();
        }

        public void Update(Note noteToUpdate)
        {
            var noteEntity = _context.Notes.Single(x => x.Id == noteToUpdate.Id);

            _mapper.Map(noteToUpdate, noteEntity);

            _context.SaveChanges();
        }

        public bool CheckIfExists(string noteId)
        {
            return _context.Notes.Any(x => x.Id == noteId && !x.IsRemoved);
        }
    }
}
