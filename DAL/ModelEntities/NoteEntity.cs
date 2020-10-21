namespace NotesManagement.DAL.ModelEntities
{
    public class NoteEntity
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool IsRemoved { get; set; }
    }
}
