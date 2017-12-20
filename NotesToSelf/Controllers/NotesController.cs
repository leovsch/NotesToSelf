using Microsoft.AspNetCore.Mvc;
using NotesToSelf.BLL.Services.Interfaces;
using NotesToSelf.BLL.ViewModels;

namespace NotesToSelf.Controllers
{
    public class NotesController : Controller
    {
        private readonly INoteService _noteService;
        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        public IActionResult Index()
        {
            return Ok("Hello World!");
        }

        [HttpPost]
        public IActionResult Create([FromBody] NoteVm newNote)
        {
            if (newNote == null)
            {
                return BadRequest();
            }
            NoteVm result = _noteService.Add(newNote);
            return Ok(result);
        }
    }
}