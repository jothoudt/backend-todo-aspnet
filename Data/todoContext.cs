using Microsoft.EntityFrameworkCore;

namespace todos
{
    public class todoContext: DbContext
    {
        public todosContext (DbContextOptions<todoContext> options)
            : base(options) ;
    }
}