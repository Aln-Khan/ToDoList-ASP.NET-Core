using ToDoList.Domain.Enum;

namespace ToDoList.Domain.Entity;

public class TaskEntity
{
    public int Id { get; set; }
    
    public bool IsDone { get; set; }
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public DateTime Created { get; set; }
    
    public Priority Priority { get; set; }
}