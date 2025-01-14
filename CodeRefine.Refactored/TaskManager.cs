namespace TaskManager.Refactored;
public class TaskManager
{
    private readonly List<AbstractTask> _tasks = new List<AbstractTask>();
    private int _idCounter = 0;

    public void AddTask(string title, string description)
    {
        if (!AreStringsValid(title, description))
        {
            Console.WriteLine("O título ou descrição inválidos!");
            return;
        }

        var id = _idCounter++;
        var task = new Task(id, title, description);
        _tasks.Add(task);
    }

    private bool AreStringsValid(string title, string description) =>
        !string.IsNullOrWhiteSpace(title) || !string.IsNullOrWhiteSpace(description);


    public void RemoveTaskById(int id) =>
        _tasks.RemoveAll(task => task.Id == id);

    public AbstractTask GetTaskById(int id)
    {
        var task = _tasks.FirstOrDefault(task => task.Id == id);
        return task ?? AbstractTask.NULL;
    }

    public List<AbstractTask> GetTasks() =>
        _tasks;

    public void MarkAllTasksAs(Status status)
    {
        if (status == Status.NotStarted) return;

        foreach (var task in _tasks)
            task.MarkAs(status);
    }
}