namespace TaskManager;
public class TaskManager
{
    private readonly List<Task> _tasks = new List<Task>();

    public void AddTask(string title, string description)
    {
        var id = GetNextId();
        var task = new Task(id, title, description);
        _tasks.Add(task);
    }

    public void RemoveTaskById(int id)
    {
        foreach (var task in _tasks)
        {
            if (task.Id == id)
            {
                _tasks.Remove(task);
                return;
            }
        }
    }

    public Task GetTaskById(int id)
    {
        Task returnTask = null;

        foreach (var task in _tasks)
        {
            if (task.Id == id)
            {
                returnTask = task;
            }
        }

        return returnTask;
    }

    public List<Task> GetTasks()
    {
        return _tasks;
    }

    public void MarkAllTasksAs(Status status)
    {
        if (status == Status.NotStarted) return;

        foreach (var task in _tasks)
        {
            task.Status = status;
        }
    }

    private int GetNextId()
    {
        var maxId = -1;

        foreach (var task in _tasks)
        {
            if (task.Id > maxId)
            {
                maxId = task.Id;
            }
        }

        return maxId + 1;
    }
}
