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


    [HttpGet("{id}")]


    [HttpPost]


    [HttpPut["{id}"]]

    [HttpDelete["{id}"]]
}