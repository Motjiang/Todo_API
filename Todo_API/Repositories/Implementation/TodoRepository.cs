using Microsoft.AspNetCore.Http.HttpResults;
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

        public async Task<Todo> CreateTodoAsync(Todo todo)
        {
            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task<Todo> DeleteTodoAsync(Guid id)
        {
            var existingtodo = await _context.Todos.FindAsync(id);

            if (existingtodo != null)
            {
                existingtodo.IsDeleted = true;
                existingtodo.DeletedDate = DateTime.Now;
                await _context.SaveChangesAsync();

                return existingtodo;
            }

            return null;
        }

        public Task<Todo> GetTodoById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Todo>> GetTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<Todo> UpdateTodoAsync(Todo todo)
        {
            var existingtodo = await _context.Todos.FirstOrDefaultAsync(t => t.Id == todo.Id);

            if (existingtodo != null)
            {
                existingtodo.IsCompleted = todo.IsCompleted;
                existingtodo.CompletedDate = DateTime.Now;
                await _context.SaveChangesAsync();

                return existingtodo;
            }

            return null;
        }
    }
}
