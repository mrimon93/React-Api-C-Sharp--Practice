using System.ComponentModel.DataAnnotations;

public class Todo {
    [Key]
    public int {get; set;}

    public string Title {get; set;}

    public bool Completed {get; set;}
}