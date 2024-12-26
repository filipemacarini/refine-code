namespace TaskManager.Refactored;
public class TaskManager
{
    private readonly List<AbstractTask> _tasks = new List<AbstractTask>();
    private int _count = 0;

    public void AddTask(string title, string description)
    {
        var id = _count++;
        var task = new Task(id, title, description);
        _tasks.Add(task);
    }

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
        foreach (var task in _tasks)
            task.MarkAs(status);
    }
}