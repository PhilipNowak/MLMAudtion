using MLM.Audtion.Core.Interfaces;
using MLM.Audtion.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLM.Audition.Domain.Services
{
    public class ToDoItemService : IToDoService
    {
        readonly IRepository<ToDoItem> _repo;

        public ToDoItemService(IRepository<ToDoItem> repo)
        {
            _repo = repo;
        }

        public ToDoItem Add(ToDoItem item)
        {
            return _repo.Insert(item);
        }

        public void Complete(ToDoItem item)
        {
            item.MarkComplere();
            _repo.Update(item);
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _repo.GetAll();
        }

        public ToDoItem GetById(int id)
        {

            //Get by Id should really be added to the repo instead of doing it in Memory
            return _repo.GetAll().Single(x => x.Id == id);
        }

        public void Update(ToDoItem item)
        {
            _repo.Update(item);
        }
    }
}
