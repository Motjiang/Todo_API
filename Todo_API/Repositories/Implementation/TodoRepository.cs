using Microsoft.EntityFrameworkCore;
using Todo_API.Data;
using Todo_API.Models.Domain;
using Todo_API.Repositories.Interface;

namespace Todo_API.Repositories.Implementation
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDbContext _context;

        public TodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        public Task<Todo> CreateTodoAsync(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Task<Todo> DeleteTodoAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Todo> GetTodoById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Todo>> GetTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        public Task<Todo> UpdateTodoAsync(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
