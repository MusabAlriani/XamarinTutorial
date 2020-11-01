using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWebApi.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string title { get; set; }
        public bool isDone { get; set; }
        public DateTime updatedAt { get; set; }

    }
}
