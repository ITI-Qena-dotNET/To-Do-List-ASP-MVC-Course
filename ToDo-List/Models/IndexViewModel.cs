namespace ToDo_List.Models;

public sealed class IndexViewModel
{
    public List<TodoTask> Tasks { get; set; }

    public string SearchFilter { get; set; }

    public TodoTaskStatus StatusFilter { get; set; }
}
