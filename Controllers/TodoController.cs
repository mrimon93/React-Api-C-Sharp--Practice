<<<<<<< HEAD
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
=======
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
>>>>>>> 0637ed46afc98d2071a8c97f81629647b5b96de0
