using NotesManagement.DAL.ModelEntities;
using System;
using System.Collections.Generic;

namespace NotesManagement.DAL
{
    public static class DataHelper
    {
        public static ICollection<NoteEntity> GenerateNotes()
        {
            var initialNotes = new List<NoteEntity>();

            for (int i = 1; i <= 5; i++)
            {
                var note = new NoteEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = $"Test Note {i}",
                    Content = $"Test Content {i}",
                };

                initialNotes.Add(note);
            }

            return initialNotes;
        }
    }
}
