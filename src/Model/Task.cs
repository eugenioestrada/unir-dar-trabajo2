namespace ToDo.Model;

public class ToDoTask
{
    public string Id { get; } = Guid.NewGuid().ToString();
    public DateTime CreationTime { get; set; }
    public DateTime DueTime { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; }
}