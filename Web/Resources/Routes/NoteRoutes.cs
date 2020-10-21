namespace NotesManagement.Web.Resources.Routes
{
    public struct NoteRoutes
    {
        public const string Default = "/";

        public const string Note = "/notes/{id}";

        public const string Notes = "/notes";

        public const string Create = "/notes/create";

        public const string UpdateGet = "/notes/update/{id}";

        public const string UpdatePost = "/notes/update/{id}";

        public const string Delete = "/notes/delete/{id}";
    }
}
