using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;


public class TodoRepository : ITodoRepository
{
    private readonly List<Todo> todos = new List<Todo>();

    public async Task<IEnumerable<Todo>> GetTodos()
    {
        return todos.ToList();
    }

    public async Task<Todo> GetTodoById(int id)
    {
        return todos.FirstOrDefault(todo => todo.Id == id);
    }

    public async Task AddTodo(Todo todo)
    {
        todos.Add(todo);
        await SaveChangesAsync();
    }

    public async Task UpdateTodo(Todo todo)
    {
        int indexOfTodo = todos.IndexOf(todo);
        if (indexOfTodo != -1)
        {
            todos[indexOfTodo] = todo;
            await SaveChangesAsync();
        }
    }

    private async Task SaveChangesAsync()
    {
        await Task.Delay(100);
    }
}