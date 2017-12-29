using AutoMapper;
using NotesToSelf.BLL.ViewModels;
using NotesToSelf.DAL.DataModels;

namespace NotesToSelf.BLL.AutoMapper.Profiles
{
    public class NotesToSelfProfile : Profile
    {
        public NotesToSelfProfile()
        {
            CreateMap<Note, NoteVm >();
            CreateMap<NoteVm, Note>();
        }
    }
}
