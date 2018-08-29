using System;
using System.Collections.Generic;
using System.Text;

namespace MLM.Audtion.Core.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get;  private set; }

        public void MarkComplere()
        {
            IsCompleted = true;
        }
    }
}
