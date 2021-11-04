using Microsoft.EntityFrameworkCore;
using todo.Models;
using Todo;

namespace Todo
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
            {
            }
            public DbSet<TodoItem> Task {get; set;}
    }
}