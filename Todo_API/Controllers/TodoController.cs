using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
