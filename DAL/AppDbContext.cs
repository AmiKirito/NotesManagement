using Microsoft.EntityFrameworkCore;
using NotesManagement.DAL.ModelEntities;
using System.Collections.Generic;

namespace NotesManagement.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public ICollection<NoteEntity> Notes = DataHelper.GenerateNotes();
    }
}
