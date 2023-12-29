# React-Api-C-Sharp--Practice


#Todo API

This project is a simple C# API for managing todos. It uses the Model-View-Controller (MVC) pattern and is organized using a folder structure that separates concerns into models, repositories, and controllers.

The app exposes endpoints for creating, reading, updating, and deleting todos. It also simulates saving changes to a database using a delay.

Features:

    Create, read, update, and delete todos
    Simulates saving changes to a database using a delay

Requirements:

    Visual Studio or another C# IDE
    .NET Core SDK 3.1 or higher

Installation:

    Clone the repository to your local machine
    Open the project in your IDE
    Restore the NuGet packages
    Run the project

Usage:

The API can be accessed using any HTTP client library, such as HttpClient in C#. For example, the following code snippet retrieves all the todos from the API:
C#

using System;
using System.Net.Http;
using System.Threading.Tasks;

public async Task Main()
{
  var client = new HttpClient();
  var response = await client.GetAsync("http://localhost:5000/api/todos");
  if (response.IsSuccessStatusCode)
  {
    var todos = await response.Content.ReadAsAsync<IEnumerable<Todo>>();
    foreach (var todo in todos)
    {
      Console.WriteLine($"ID: {todo.Id} - Title: {todo.Title} - Completed: {todo.Completed}");
    }
  }
  else
  {
    Console.WriteLine($"Error: {response.StatusCode}");
  }
}

Var försiktig när du använder koden. Läs mer

This code will print the following output:

ID: 1 - Title: New Todo - Completed: False
ID: 2 - Title: Update Todo - Completed: True

Please note that the actual todos are stored in memory in the TodoRepository class. In a real-world application, the TodoRepository would interact with a database to store and retrieve todos.
