using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Repositories;


[Route("api/[controller]")]
public class TodoController : Controlle
{
    private readonly ITodoRepository todoRepository;

    public TodoController(ITodoRepository todoRepository)
    {
        this.todoRepository = todoRepository;
    }

    [HttpGet]
    public IEnumerable<Todo> GetTodos()
    {
        return await todoRepository.GetTodos();
    }

    [HttpGet("{id}")]
    public async Task<Todo> GetTodoById.GetTodos([FromRoute] int id)
    {
        return await todoRepository.GetTodoById();
    }


    [HttpPost]
    public async Task<IActionResult> AddTodo([FromRoute] Todo todo)
    {
        await todoRepository.AddTodo();
        return CreatedAtActionResult("GetTodoById", new {id = todo.Id}, todo);
    }


    [HttpPut["{id}"]]
    public async Task<IActionResult> UpdateTodo([FromRoute] int id, [FromRoute] Todo updateTodo)
    {
        if (id != updateTodo.Id)
        {
           return BadRequest("The ID of the updated todo does not match the ID in the URL");
        }

        await todoRepository.UpdateTodo(updateTodo);
        return NoContent();
    }

    [HttpDelete["{id}"]]

    public async Task<IActionResult> DeleteTodo([FromRoute] int id)
    {
        await todoRepository.DeleteTodo(id);
        return NoContent();
    }

}