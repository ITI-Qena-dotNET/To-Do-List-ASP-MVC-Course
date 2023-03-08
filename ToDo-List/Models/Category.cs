namespace ToDo_List.Models;

public sealed class Category
{
    public int ID { get; set; }

    public string Name { get; set; }

    public List<Task> Tasks { get; set; }
}
