namespace ToDo_List.Models;

public sealed class Task
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime AssignDate { get; set;}

    public TaskStatus Status { get; set; }

    public User User { get; set; }

    public List<Category> Categories { get; set; }
}

public enum TaskStatus
{
    Open,
    InProgress,
    Done
}