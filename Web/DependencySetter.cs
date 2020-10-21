using NotesManagement.BLL.Interfaces.Services;
using NotesManagement.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using NotesManagement.BLL.Interfaces.Repositories;
using NotesManagement.DAL.Repositories;

namespace NotesManagement.Web
{
    public static class DependencySetter
    {
        public static void SetDependencies(IServiceCollection services)
        {
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<INoteRepository, NoteRepository>();
        }
    }
}
