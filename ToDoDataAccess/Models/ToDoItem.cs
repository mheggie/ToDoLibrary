using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoDataAccess.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string CompletedDate { get; set; }

    }
}
