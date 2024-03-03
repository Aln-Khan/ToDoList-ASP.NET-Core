using ToDoList.Domain.Enum;

namespace ToDoList.Domain.ViewModel.Task;

public class CreateTaskViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new ArgumentNullException(Name, "Вы не ввели задачу");
        }

        if (string.IsNullOrWhiteSpace(Description))
        {
            throw new ArgumentNullException(Description, "Вы не ввели описание задачи");
        }
    }
}