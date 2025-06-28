namespace TodoApp.Models; // This organizes code into a logical container;
// so TodoApp.Models means that this file TodoItem.cs is part of the Models 
// namespace within our app (notice our project name is TodoApp).
// We can refer to this code somewhere else by saing `using TodoApp.Models;`




// We want our app to add, store, display, and mark the status of tasks.
// A todo item has a *name* (Task) and a *status* (IsCompleted)
public class TodoItem
{
    // Auto properties
    public string Task { get; set; }
    // get = read the value, set = assign a value
    public bool IsCompleted { get; set; }
}