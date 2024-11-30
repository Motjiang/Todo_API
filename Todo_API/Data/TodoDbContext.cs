using Microsoft.EntityFrameworkCore;
using Todo_API.Models.Domain;

namespace Todo_API.Data
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }    
}
