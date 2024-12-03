using Todo_API.Models.Domain;

namespace Todo_API.Repositories.Interface
{
    public interface ITodoRepository
    {       
        Task<IEnumerable<Todo>> GetTodos();
        Task<Todo> GetTodoById(Guid id);
        Task<Todo> CreateTodoAsync(Todo todo);
        Task<Todo> UpdateTodoAsync(Todo todo);
        Task<Todo> DeleteTodoAsync(Guid id);
        Task<IEnumerable<Todo>> GetDeletedTodos();
    }
}
