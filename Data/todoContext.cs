using Microsoft.EntityFrameworkCore;
using todo.Models;

namespace Todo
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
            {
            }
            public DbSet<Task> Task {get; set;}
    }
}