using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_API.Models.Domain;
using Todo_API.Models.DTO;
using Todo_API.Repositories.Interface;

namespace Todo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var todos = await _todoRepository.GetTodos();
            return Ok(todos);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodoAsync([FromBody] TodoDto request)
        {
            // Map TodoDto to Todo domain model
            var todo = new Todo
            {
                Description = request.TaskDescription,
                CreatedDate = request.TaskCreatedDate,
                IsCompleted = request.IsTaskCompleted,
                CompletedDate = request.TaskCompletedDate
            };

            todo.Id = Guid.NewGuid();
            // Create Todo
            var createdTodo = await _todoRepository.CreateTodoAsync(todo);


            // Map Todo domain model to TodoDto
            var response = new TodoDto
            {
                TaskDescription = createdTodo.Description,
                TaskCreatedDate = createdTodo.CreatedDate,
                IsTaskCompleted = createdTodo.IsCompleted,
                TaskCompletedDate = createdTodo.CompletedDate
            };

            return Ok(response);

        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateTodo([FromRoute] Guid id, TodoDto request)
        {
            // Map TodoDto to Todo domain model
            var todo = new Todo
            {
                Id = id,
                Description = request.TaskDescription,
                CreatedDate = request.TaskCreatedDate,
                IsCompleted = request.IsTaskCompleted,
                CompletedDate = request.TaskCompletedDate
            };

            todo = await _todoRepository.UpdateTodoAsync(todo);

            if(todo == null)
            {
                return NotFound();
            }

            // Map Todo domain model to TodoDto
            var response = new TodoRequestDto
            {
                TaskId = todo.Id,
                TaskDescription = todo.Description,
                TaskCreatedDate = todo.CreatedDate,
                IsTaskCompleted = todo.IsCompleted,
                TaskCompletedDate = todo.CompletedDate
            };

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteTodo([FromRoute] Guid id)
        {
            // Retrieve the Todo by Id and delete it
            var todo = await _todoRepository.DeleteTodoAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            // Map Todo domain model to TodoRequestDto (if needed for the response)
            var response = new TodoRequestDto
            {
                TaskId = todo.Id,
                TaskDescription = todo.Description,
                TaskCreatedDate = todo.CreatedDate,
                IsTaskCompleted = todo.IsCompleted,
                TaskCompletedDate = todo.CompletedDate,
                IsTaskDeleted = todo.IsDeleted,
                TaskDeletedDate = todo.DeletedDate
            };

            return Ok(response);
        }       
    }
}
