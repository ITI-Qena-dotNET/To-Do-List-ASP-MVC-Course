namespace ToDo_List.Models;

public sealed class TodoTask
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime AssignDate { get; set;}

    public TodoTaskStatus Status { get; set; }

    public int UserID { get; set; }

    public User User { get; set; }

    public List<Category> Categories { get; set; }
}

public enum TodoTaskStatus
{
    Open,
    InProgress,
    Done
}