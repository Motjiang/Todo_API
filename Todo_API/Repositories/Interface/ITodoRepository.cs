using Todo_API.Models.Domain;
using Todo_API.Models.DTO;
using Todo_API.Models.Helper;

namespace Todo_API.Repositories.Interface
{
    public interface ITodoRepository
    {       
        Task<IEnumerable<Todo>> GetTodos();
        Task<Todo> GetTodoById(Guid id);
        Task<Todo> CreateTodoAsync(Todo todo);
        Task<Todo> UpdateTodoAsync(Todo todo);
        Task<Todo> DeleteTodoAsync(Guid id);
        Task<PagedList<Todo>> GetDeletedTodos(TodoParamsDto paramsDto);
        Task<Todo> UpdateUndoTodoAsync(Todo todo);
    }
}
