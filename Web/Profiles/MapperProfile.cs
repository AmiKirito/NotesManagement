using AutoMapper;
using NotesManagement.BLL.Models;
using NotesManagement.DAL.ModelEntities;
using NotesManagement.Web.ViewModels;

namespace NotesManagement.Web.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Note, NoteViewModel>();
            CreateMap<NoteEntity, Note>().ReverseMap();
            CreateMap<CreateNoteViewModel, Note>();
            CreateMap<UpdateNoteViewModel, Note>().ReverseMap();
        }
    }
}
