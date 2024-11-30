using Todo_API.Models.Domain;
using Todo_API.Repositories.Interface;

namespace Todo_API.Repositories.Implementation
{
    public class TodoRepository : ITodoRepository
    {
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

        public Task<IEnumerable<Todo>> GetTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Todo> UpdateTodoAsync(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
