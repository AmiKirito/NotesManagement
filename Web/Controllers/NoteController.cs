using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotesManagement.BLL.Interfaces.Services;
using NotesManagement.BLL.Models;
using NotesManagement.Web.Resources.ActionNames;
using NotesManagement.Web.Resources.ControllerNames;
using NotesManagement.Web.Resources.Routes;
using NotesManagement.Web.Resources.ViewNames;
using NotesManagement.Web.ViewModels;
using System.Collections.Generic;

namespace NotesManagement.Web.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        public NoteController(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;
        }

        [Route(NoteRoutes.Note)]
        public IActionResult GetNote(string id)
        {
            if (!_noteService.CheckIfExists(id))
            {
                return View(Views.NotFound, id);
            }

            var note = _noteService.Get(id);

            var model = _mapper.Map<NoteViewModel>(note);

            return View(model);
        }

        [Route(NoteRoutes.Default)]
        [Route(NoteRoutes.Notes)]
        public IActionResult GetNotes()
        {
            var notes = _noteService.GetAll();

            var model = _mapper.Map<List<NoteViewModel>>(notes);

            return View(model);
        }

        [HttpGet]
        [Route(NoteRoutes.Create)]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route(NoteRoutes.Create)]
        public IActionResult Create(CreateNoteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var noteToAdd = _mapper.Map<Note>(model);

            _noteService.Create(noteToAdd);

            return RedirectToAction(NoteActions.GetNotes, ControllerNames.Note);
        }

        [HttpGet]
        [Route(NoteRoutes.UpdateGet)]
        public IActionResult Update(string id)
        {
            if (!_noteService.CheckIfExists(id))
            {
                return View(Views.NotFound, id);
            }

            var note = _noteService.Get(id);

            var model = _mapper.Map<UpdateNoteViewModel>(note);

            return View(model);
        }

        [Route(NoteRoutes.UpdatePost)]
        [HttpPost]
        public IActionResult Update(string id, [FromForm]UpdateNoteViewModel model)
        {
            if (!_noteService.CheckIfExists(id))
            {
                return View(Views.NotFound, id);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var noteToUpdate = _mapper.Map<Note>(model);

            _noteService.Update(noteToUpdate);

            var idModel = new 
            {
                id = model.Id
            };

            return RedirectToAction(NoteActions.GetNote, ControllerNames.Note, idModel);
        }

        [Route(NoteRoutes.Delete)]
        public IActionResult Delete(string id)
        {
            if (!_noteService.CheckIfExists(id))
            {
                return View(Views.NotFound, id);
            }

            _noteService.Detele(id);

            return RedirectToAction(NoteActions.GetNotes, ControllerNames.Note);
        }

    }
}
