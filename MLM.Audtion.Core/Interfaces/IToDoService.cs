using MLM.Audtion.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLM.Audtion.Core.Interfaces
{
    public interface IToDoService
    {
        ToDoItem Add(ToDoItem item);

        void Update(ToDoItem item);

        IEnumerable<ToDoItem> GetAll();

        void Complete(ToDoItem item);

        ToDoItem GetById(int Id);
    }
}
