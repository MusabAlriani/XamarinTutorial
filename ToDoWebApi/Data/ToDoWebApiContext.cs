using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoWebApi.Models;

namespace ToDoWebApi.Models
{
    public class ToDoWebApiContext : DbContext
    {
        public ToDoWebApiContext (DbContextOptions<ToDoWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}
