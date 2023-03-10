namespace ToDo_List.Models;

public sealed class User
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public List<TodoTask> TasksAssigned { get; set; }
}
