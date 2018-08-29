using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MLM.Audtion.Core.Interfaces;
using MLM.Audtion.Core.Models;

namespace MLM.Audition.Controllers
{
    public class ToDoItemController : Controller
    {
       readonly IToDoService _service;

        public ToDoItemController(IToDoService service)
        {
            _service = service;
        }

        // GET: ToDoItem
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        // GET: ToDoItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDoItem item)
        {
            try
            {
                _service.Add(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoItem/Edit/5
        public ActionResult Edit(int id)
        {
            //This should be added to the 
            
            return View(_service.GetById(id));
        }

        // POST: ToDoItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ToDoItem item)
        {
            try
            {
                _service.Update(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoItem/Delete/5
        public ActionResult Completed(int id)
        {
            var item = _service.GetById(id);
            _service.Complete(item);
            return RedirectToAction(nameof(Index));
        }

    }
}