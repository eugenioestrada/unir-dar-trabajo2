namespace ToDo.Model;

public class ToDoTask
{
    public DateTime CreationTime { get; set; }
    public DateTime DueTime { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; }
}