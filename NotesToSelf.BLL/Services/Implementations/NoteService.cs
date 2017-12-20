using AutoMapper;
using NotesToSelf.BLL.Services.Interfaces;
using NotesToSelf.BLL.ViewModels;
using NotesToSelf.DAL.DataModels;
using NotesToSelf.DAL.Repositories.Interfaces;

namespace NotesToSelf.BLL.Services.Implementations
{
    public class NoteService : BaseService<Note, NoteVm>, INoteService
    {
        public NoteService(IBaseRepository<Note> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
