using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
public class TodoController : Controller
{
    private readonly ITodoRepository todoRepository;

    public TodoController(ITodoRepository todoRepository)
    {
        this.todoRepository = todoRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Todo>> GetTodos()
    {
        return await todoRepository.GetTodos();
    }

    [HttpGet("{id}")]
    public async Task<Todo> GetTodoById([FromRoute] int id)
    {
        return await todoRepository.GetTodoById(id);
    }

    [HttpPost]
    public async Task<IActionResult> AddTodo([FromBody] Todo todo)
    {
        await todoRepository.AddTodo(todo);
        return CreatedAtAction("GetTodoById", new { id = todo.Id }, todo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTodo([FromRoute] int id, [FromBody] Todo updateTodo)
    {
        if (id != updateTodo.Id)
        {
            return BadRequest("The ID of the updated todo does not match the ID in the URL");
        }

        await todoRepository.UpdateTodo(updateTodo);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo([FromRoute] int id)
    {
        await todoRepository.DeleteTodo(id);
        return NoContent();
    }
}
