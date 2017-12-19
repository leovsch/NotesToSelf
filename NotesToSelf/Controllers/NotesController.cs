using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesToSelf.ViewModels;

namespace NotesToSelf.Controllers
{
    public class NotesController : Controller
    {
        [HttpPost]
        public IActionResult Create([FromBody] NoteVm newNote)
        {
            if (newNote == null)
            {
                return BadRequest();
            }

            throw new NotImplementedException();
        }
    }
}