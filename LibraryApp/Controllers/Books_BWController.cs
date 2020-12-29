using System;
using Library.API.Data.Models;
using Library.API.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class Books_BWController : Controller
    {
        public readonly IBookService _service;
        public Books_BWController(IBookService service)
        {
            _service = service;
        }

        // GET: Books
        public ActionResult Index()
        {
            var result = _service.GetAll();
            return View(result);
        }

        // GET: Books/Details/5
        public ActionResult Details(Guid id)
        {
            var result = _service.GetById(id);
            if(result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // GET: Books/Create
        public ActionResult Create_BW()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_BW(Book_BW item)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                _service.Add(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Books/Delete/5
        public ActionResult Delete_BW(Guid id)
        {
            var result = _service.GetById(id);
            return View(result);
        }

        // POST: Books/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_BW(Guid id, IFormCollection collection)
        {
            try
            {
                _service.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}