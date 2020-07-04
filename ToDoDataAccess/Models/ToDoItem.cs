using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoDataAccess.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool Active { get; set; }

    }
}
